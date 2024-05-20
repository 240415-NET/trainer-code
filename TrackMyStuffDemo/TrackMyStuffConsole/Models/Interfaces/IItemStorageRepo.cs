namespace TrackMyStuff.Models;


public interface IItemStorageRepo
{
    //Here I will add all of the storage methods
    public void StoreItem(Item newItem);
    public void StoreDocument(Document newDocument);
    public void StorePet(Pet newPet);

    public List<Item> GetItems(Guid userID, int listType);

    
}