using TrackMyStuff.Models;
using TrackMyStuff.Data;
using System.Diagnostics.Contracts;

namespace TrackMyStuff.Controllers;


public class ItemController
{

    private static IItemStorageRepo _itemData = new JsonItemStorage();

    public static void CreateItem(User user, string category, double originalCost, DateTime purchaseDate, string description)
    {
        //Creating the item
        Item newItem = new Item(user.userId,category,originalCost,purchaseDate,description);
        
        _itemData.StoreItem(newItem, user.userId);
    }
    public static void CreatePet(User user, string category, double originalCost, DateTime purchaseDate, string description,string petName,string petSpecies,int petAge)
    {
        //Creating the item
        Pet newPet = new Pet(user.userId,category,originalCost,purchaseDate,description,petName,petSpecies,petAge);
        
        _itemData.StoreItem(newPet,user.userId);
    }
    public static void CreateDocument(User user, string category, double originalCost, DateTime purchaseDate, string description, string documentType, DateTime expirationDate)
    {
        //Creating the item
        Document newDocument = new Document(user.userId,category,originalCost,purchaseDate,description,documentType,expirationDate);
        
        _itemData.StoreItem(newDocument,user.userId);
    }        
   
}