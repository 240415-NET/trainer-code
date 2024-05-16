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
        Item newItem = new Item(user.userId, category, originalCost, purchaseDate, description);

        _itemData.StoreItem(newItem);
    }
    public static void CreatePet(User user, string category, double originalCost, DateTime purchaseDate, string description, string petName, string petSpecies, int petAge)
    {
        //Creating the item
        Pet newPet = new Pet(user.userId, category, originalCost, purchaseDate, description, petName, petSpecies, petAge);

        _itemData.StorePet(newPet);
    }
    public static void CreateDocument(User user, string category, double originalCost, DateTime purchaseDate, string description, string documentType, DateTime expirationDate)
    {
        //Creating the item
        Document newDocument = new Document(user.userId, category, originalCost, purchaseDate, description, documentType, expirationDate);

        _itemData.StoreDocument(newDocument);
    }
    public static List<Item> GetAllItems(Guid userID)
    {
        return _itemData.GetItems(userID, 4);
    }
    public static List<Item> GetItems(Guid userID)
    {
        return _itemData.GetItems(userID, 1);
    }
    public static List<Pet> GetPets(Guid userID)
    {
        List<Item> startingList = new();
        startingList = _itemData.GetItems(userID, 2);
        List<Pet> returnList = new();
        foreach(Item item in startingList)
        {
            returnList.Add((Pet)item);
        }
        return returnList;
    }
    public static List<Document> GetDocuments(Guid userID)
    {
        List<Item> startingList = new();
        startingList = _itemData.GetItems(userID, 3);
        List<Document> returnList = new();
        foreach(Item item in startingList)
        {
            returnList.Add((Document)item);
        }
        return returnList;
    }
}