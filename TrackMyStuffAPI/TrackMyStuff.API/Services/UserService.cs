using TrackMyStuff.API.Models;

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

}