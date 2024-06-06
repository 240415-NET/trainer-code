using TrackMyStuff.API.Models;
using TrackMyStuff.API.Data;

namespace TrackMyStuff.API.Services;

public class UserService : IUserService
{
    //The same way that our UserService is given to our UserController via Dependency Injection,
    //we need something to store our data access object for database operations relating to the User model
    //Again, we will create private readonly objects that we don't create using "new" anywhere in this class
    private readonly IUserStorageEFRepo _userStorage;

    public UserService(IUserStorageEFRepo efRepoFromBuilder)
    {
        _userStorage = efRepoFromBuilder;
    }

    //This method will hold the business logic that we decide on for creating a new user.
    //It is called by our UserController's PostNewUser() method, and it then will *hopefully*
    //call our UserStorageEFRepo's method for sticking the new user into the database.
    //Even with the increasing scope of our applications, we respect layer separation. 
    public async Task<User> CreateNewUserAsync(User newUserSentFromController)
    {
        //Our rules for being able to create a new user
        //1. No duplicate names
        //2. Name cannot be blank

        //Because we are not using any direct Console user interaction, we use exceptions as part
        //of our input validation. If the user doesn't meet our logic's requirements, we manually
        //throw exceptions that then trigger the catch block inside of our UserController. 

        //We can throw specific exceptions here, that can trigger different try blocks in our UserController's method.

        //Checking if a user already exists, via the username and the UserExists() method. 
        //Here, for readability, I checked for the return with "== true"
        //But since it already returns a boolean, I can omit that. 
        if(await UserExistsAsync(newUserSentFromController.userName) == true)
        {
            //If this returns a true, and we enter this code block, we will manually THROW an exception.
            //This will trigger the catch in the UserController, and send our message to the user. 
            throw new Exception("User already exists");
        }

        //Checking to see if the username is blank.
        if(String.IsNullOrEmpty(newUserSentFromController.userName) == true)
        {
            throw new Exception("Username cannot be blank!");
        }
        
        //At some point, we will have to call the data access layer before creating a new user and
        //check for an existing user with that name. 
        await _userStorage.CreateUserInDBAsync(newUserSentFromController);
        
        //If this all goes smooth, and we successfully call the method in the data access layer to create a new user
        //we will just echo back the object that was sent to us by the controller. Later on, we can actually worry about
        //a more meaningful return.
        return newUserSentFromController;
    }

    public async Task<User> GetUserByUsernameAsync(string usernameToFindFromController)
    {
        //So here we check, before we ever pass the string to the data access layer to see if the front end 
        //passed us an empty or null string. If either of those are true, we don't even hit the data access layer,
        //we just return this manually thrown exception
        if(String.IsNullOrEmpty(usernameToFindFromController))
        {
            throw new Exception("Cannot pass in a null or empty string!");
        }


        //Here, we do call the data access layer. Because at this point, we have no idea if the given string corresponds
        //to a user object, we don't know how this method call will go. So we wrap it in a try-catch so that we don't crash the entire
        //API if someone makes a typo from the front end. 
        try
        {   

            //Creating a user object that can be null, in order to check if our user was actually found BEFORE returning it to
            //the controller layer
            User? foundUser =  await _userStorage.GetUserFromDBByUsernameAsync(usernameToFindFromController);


            //If our data access layer's SingleOrDefaultAsync call DOESN'T find a user that has the given passed in username, 
            //it will return a null. Here we check for that null, and if foundUser is null, we manually throw an exception that
            //is caught in the try-catch of the controller - and that gets sent back to the front-end. 
            if(foundUser == null)
            {
                throw new Exception("User not found in DB?");
            }

            return foundUser;


        }
        catch(Exception e)
        {
            throw new Exception(e.Message);
        }

    }
    
    public async void DeleteUserByUsernameAsync(string usernameToDeleteFromController)
    {
        //Let's leverage UserExistsAsync
        //IF the user exists, we delete it.

        

        try
        {
            if(await UserExistsAsync(usernameToDeleteFromController) == true)
            {
                _userStorage.DeleteUserFromDBAsync(usernameToDeleteFromController);
            }
            else
            {
                throw new Exception("User doesn't exist! Can't be deleted.");
            }
        }
        catch(Exception e)
        {
            throw new Exception(e.Message);
        }
        //If not, we throw an exception to enter the controller's catch block

    }


    //Method to check if a user exists... during early development we will return a false every time.
    //Later on, we can then flesh this our more. 
    public async Task<bool> UserExistsAsync(string usernameToFindFromController)
    {
        return await _userStorage.DoesThisUserExistOnDBAsync(usernameToFindFromController);
    } 


}