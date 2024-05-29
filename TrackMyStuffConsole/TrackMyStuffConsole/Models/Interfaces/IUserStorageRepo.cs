namespace TrackMyStuff.Models;


public interface IUserStorageRepo
{
    //Here I will add all of the storage methods
    public void StoreUser(User user);
    public User FindUser(string usernameToFind);

}