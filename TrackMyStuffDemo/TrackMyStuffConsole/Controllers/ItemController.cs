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

        _itemData.StoreItem(newPet);
    }
  
    public static void CreateDocument(User user, string category, double originalCost, DateTime purchaseDate, string description, string documentType, DateTime expirationDate)
    {
        //Creating the item
        Document newDocument = new Document(user.userId, category, originalCost, purchaseDate, description, documentType, expirationDate);

        _itemData.StoreItem(newDocument);
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

    public static void RemoveItem(Guid itemId, Guid userID)
    {
        ItemsDTO returnedDTO = DTOStorage.DeserializeAllItems();

         if(returnedDTO != null)
        {

            foreach(Item I in returnedDTO.Items)
            {
                Console.WriteLine($"Index = {returnedDTO.Items.IndexOf(I)} {I.AbbrToString()} Id = {I.itemId}");
            }
            foreach(Document D in returnedDTO.Documents)
            {
                // Console.WriteLine($"Index = {VehiclesObject.Trucks.IndexOf(v) + VehiclesObject.Cars.Count} {v}");
                Console.WriteLine($"Index = {returnedDTO.Documents.IndexOf(D) + returnedDTO.Items.Count} {D.AbbrToString()} Id = {D.itemId}");
            }
            foreach(Pet P in returnedDTO.Pets)
            {
                Console.WriteLine($"Index = {returnedDTO.Pets.IndexOf(P) + returnedDTO.Items.Count + returnedDTO.Documents.Count} {P.AbbrToString()} Id = {P.itemId}");
            }
        }else
        {
            Console.WriteLine("No items found");
        }


    }

}