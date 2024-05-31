using TrackMyStuff.API.Models;
using TrackMyStuff.API.DTOs;
using Microsoft.EntityFrameworkCore;

namespace TrackMyStuff.API.Data;

public class UserStorageEFRepo : IUserStorageEFRepo
{
    private readonly TrackMyStuffContext _context;
    public UserStorageEFRepo(TrackMyStuffContext contextFromBuilder)
    {
        _context = contextFromBuilder;
    }

    public async Task<User?> CreateUserInDBAsync(User newUserSentFromUserService)
    {
        //Here we will actually create the user in our DB

        return newUserSentFromUserService;
    }
}

