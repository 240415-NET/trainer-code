namespace TrackMyStuff.Models;


public interface IItemStorageRepo
{
    //Here I will add all of the storage methods
    public void StoreItem(Item newItem, Guid userGUID);
    
}