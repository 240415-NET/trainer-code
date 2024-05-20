
using TrackMyStuff.Models;
using TrackMyStuff.Data;
using TrackMyStuff.Controllers;

namespace TrackMyStuff;

public static class ModifyItems
{
    static JsonItemStorage repo = new JsonItemStorage();


    public static void ModifyIndividualItem(Item itemToBeModified, List<string> propertiesToBeModified)
    {
        // itemToBeModified.description = newDescription;
        // itemsToBeModified.Add(itemToBeModified);
        if(itemToBeModified.GetType() == "Item")
        { 
            repo.ModifyItem(itemToBeModified, propertiesToBeModified);
        }        
        if(itemToBeModified.GetType() == "Pet")
        { 
            Pet petToBeModified = (Pet) itemToBeModified;
            repo.ModifyItem(petToBeModified, propertiesToBeModified);
        }        
        if(itemToBeModified.GetType() == "Document")
        { 
            Document docToBeModified = (Document) itemToBeModified;
            
        }        

        repo.ModifyItem(itemToBeModified, propertiesToBeModified);
    }

    public static void ModifyItemsFromList(List<Item> itemsToBeModified, User user)
    {
        IItemStorageRepo itemStorage = new JsonItemStorage();
        ItemsDTO returnedDTO = DTOStorage.DeserializeAllItems();
        foreach(Item item in itemsToBeModified)
        {
            // ItemController.RemoveItem(item.itemId, user);
            // Console.WriteLine($"{item.itemId} was removed!"); // for testing to be removed later

            // itemStorage.StoreItem(item);
            // Console.WriteLine($"{item.itemId} was re-added with {item.description}"); // for testing to be removed later

           // repo.ModifyItem(item, item.description);
            
        }
    }

}