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
}

