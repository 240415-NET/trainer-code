namespace TrackMyStuff.Models;

public interface IUserStorageRepo
{

    public void StoreUser(User user);
    public User FindUser(string usernameToFind);



}