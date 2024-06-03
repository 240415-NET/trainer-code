using TrackMyStuff.API.Models;
using TrackMyStuff.API.DTOs;
using Microsoft.EntityFrameworkCore;

namespace TrackMyStuff.API.Data;

public class UserStorageEFRepo : IUserStorageEFRepo
{
    //This holds our context object that will actually do the databsae data transfer stuff
    //for us using prebuild EF Core methods
    private readonly TrackMyStuffContext _context;
    public UserStorageEFRepo(TrackMyStuffContext contextFromBuilder)
    {
        _context = contextFromBuilder;
    }

    public async Task<User?> CreateUserInDBAsync(User newUserSentFromUserService)
    {
        //Here we will actually create the user in our DB

        //First we use the context object, reference the table we want to add the object to,
        //and then use .Add() to add it to stage it for saving.
        _context.Users.Add(newUserSentFromUserService);

        //We can add as many objects as we need to before we save, but be mindful that nothing
        //actually reflects in the DB until we call SaveChangesAsync().
        
        //This line, that we await, is what actually sticks our user into our database.
        await _context.SaveChangesAsync();

        return newUserSentFromUserService;
    }

    public async Task<User?> GetUserFromDBByUsernameAsync (string usernameToFindFromUserService)
    {

        //We are going to attempt to find a User based on the string passed in using LINQ
        //In this method call, we ask using LINQ for the a single user based on it's username matching the usernameToFind we passed in
        User? foundUser = await _context.Users.SingleOrDefaultAsync(user => user.userName == usernameToFindFromUserService);

        //Returning either the user we found OR null to the service layer.
        //Checking for a null in our application will be part of the business logic. 
        return foundUser;
    }
}

