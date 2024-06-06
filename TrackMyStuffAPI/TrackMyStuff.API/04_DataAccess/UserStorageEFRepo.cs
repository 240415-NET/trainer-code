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

    //New Method, using the .Any() LINQ method to check if a user exists on our DB. 
    //This method will return a boolean, it does not care about returning any sort of user object
    //or information on a user if they exist. Just whether or not they exist at all.
    public async Task<bool> DoesThisUserExistOnDBAsync (string usernameToFindFromUserService)
    {
        //We are just going to call the .Any() method, which returns a boolean true/false.
        //If the user exists in the DB, it resolves to true
        //Otherwise it resolves to false
        return await _context.Users.AnyAsync(user => user.userName == usernameToFindFromUserService);

    }

    public async void DeleteUserFromDBAsync(string usernameToDeleteFromUserService)
    {
        //So in this one line, we do a few things.
        //We KNOW coming into this method, that we already checked if the user exists. So by definition, 
        //we WILL be deleting someone here. We call the .Remove() EF Core method, to remove the user object passed
        //into it from the database. 
        //Instead of going through the steps to find a user again, we simply call the GetUserFromDBByUsernameAsync method 
        //that we already created, and resuse it to provide our user to be deleted. 
        User userToDelete = await GetUserFromDBByUsernameAsync(usernameToDeleteFromUserService);

        if (userToDelete == null)
        {
            throw new Exception("Thrown from the db layer, userToDelete was null");
        }
    
        _context.Users.Remove(userToDelete);

        //Just like a POST, we then need to call SaveChanges or SaveChangesAsync using our _context object to persist this 
        //deletion to the DB
        await _context.SaveChangesAsync();
    }
}

