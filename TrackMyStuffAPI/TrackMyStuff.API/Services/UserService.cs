using TrackMyStuff.API.Models;

namespace TrackMyStuff.API.Services;

public class UserService : IUserService
{
    //The same way that our UserService is given to our UserController via Dependency Injection,
    //we need something to store our data access object for database operations relating to the User model
    //Again, we will create private readonly objects that we don't create using "new" anywhere in this class
    //private readonly IUserStorageEFRepo _userStorage;

    public UserService()
    {
        //_userStorage = efRepoFromBuilder;
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
        if(UserExists(newUserSentFromController.userName) == true)
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
        //await _userStorage.CreateUserInDBAsync(newUserSentFromController);
        
        //If this all goes smooth, and we successfully call the method in the data access layer to create a new user
        //we will just echo back the object that was sent to us by the controller. Later on, we can actually worry about
        //a more meaningful return.
        return newUserSentFromController;
    }

    //Method to check if a user exists... during early development we will return a false every time.
    //Later on, we can then flesh this our more. 
    public bool UserExists(string userName)
    {
        return false;
    } 
}