using TrackMyStuff.Models;
using TrackMyStuff.Data;

namespace TrackMyStuff.Controllers;


public class ItemController
{

    private static IItemStorageRepo _itemData = new JsonItemStorage();

    public static void CreateItem(User user, string category, double originalCost, DateTime purchaseDate, string description)
    {
        //Creating the item
        Item newItem = new Item(user.userId,category,originalCost,purchaseDate,description);
        
        _itemData.StoreItem(newItem);
    }
   
}