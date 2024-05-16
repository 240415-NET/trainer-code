namespace TrackMyStuff.Models;


public interface IItemStorageRepo
{
    //Here I will add all of the storage methods
    public void StoreItem(Item newItem);
<<<<<<< HEAD
    public void StoreDocument(Document newDocument);
    public void StorePet(Pet newPet);
=======

>>>>>>> 9886d7cee02ec912b81ca8b93ebaa8b90ed624cc
    public List<Item> GetItems(Guid userID, int listType);

    
}