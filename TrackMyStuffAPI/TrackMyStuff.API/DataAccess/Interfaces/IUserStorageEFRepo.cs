using TrackMyStuff.API.Models;

namespace TrackMyStuff.API.Data;

public interface IUserStorageEFRepo
{
    public Task<User?> CreateUserInDBAsync(User newUserSentFromUserService);
    public Task<User?> GetUserFromDBByUsernameAsync (string usernameToFindFromUserService);
    public Task<bool> DoesThisUserExistOnDBAsync (string usernameToFindFromUserService);
}