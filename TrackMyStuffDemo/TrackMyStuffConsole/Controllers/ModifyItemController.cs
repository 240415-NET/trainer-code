
using TrackMyStuff.Models;
using TrackMyStuff.Data;

namespace TrackMyStuff;

public static class ModifyItems
{


    public static void ModifyIndividualItem(Item itemToBeModified, string newDescription, List<Item> itemsToBeModified )
    {
        itemToBeModified.description = newDescription;
        itemsToBeModified.Add(itemToBeModified);        
    }

    public static void ModifyItemsFromList(List<Item> itemsToBeModified)
    {
        IItemStorageRepo itemStorage = new JsonItemStorage();
        foreach(Item item in itemsToBeModified)
        {
            //Remove(item.itemID)
            Console.WriteLine($"{item.itemId} was removed!"); // for testing to be removed later

            itemStorage.StoreItem(item);
            Console.WriteLine($"{item.itemId} was re-added with {item.description}"); // for testing to be removed later
        }
    }

    

}