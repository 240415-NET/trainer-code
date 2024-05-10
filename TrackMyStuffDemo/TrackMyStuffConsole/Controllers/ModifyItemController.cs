
using TrackMyStuff.Models;

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
        foreach(Item item in itemsToBeModified)
        {
            //Remove(item.itemID) 

            //Add(item)
        }
    }

}