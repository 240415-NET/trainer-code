using TrackMyStuff.Models;
using TrackMyStuff.Data;

namespace TrackMyStuff.Controllers;

//This is my "controller"
//This controller handles all business logic related to the user class
//It will contain mostly if not only methods, atleast until we decide to add things like logging
//later on during training. 
public class UserController
{
    
    //This function handles the business logic related to creating a new 
    //user profile, using the User class
    //It will take input from another function in the presentation layer for the username.
    //It will then, create the user object that we will eventually store
    //And it will pass that created user object to the data access layer
    public static void CreateUser(string userName)
    {
        //Creating the user
        User newUser = new User(userName);
        
        //Adding a WriteLine to just verify that we got here from the presentation layer
        //Console.WriteLine($"User {newUser.userName} created using CreateUser()!");
        //Console.WriteLine($"{newUser.userId}");

        //.. eventually, we will come here and call a Data Access Layer method to store the user
        UserStorage.StoreUser(newUser);
    }

    //This function will *eventually* be used to check if a given username already exists in our data store
    public static bool UserExists(string userName)
    {
        //We will need to write some method in our UserStorage.cs (Data Access Layer) that can find a user
        //if they exist
        if(UserStorage.FindUser(userName) != null)
        {
            return true;
        }

        return false;
    }

    // This function returns user information from our data layer
    public static User ReturnUser (string userName)

    {
        User existingUser = UserStorage.FindUser(userName);
        return existingUser;
    }
    
}