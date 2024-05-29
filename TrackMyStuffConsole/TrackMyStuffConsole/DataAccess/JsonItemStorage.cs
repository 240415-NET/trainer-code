using TrackMyStuff.Models;
using System.Text.Json;

namespace TrackMyStuff.Data;

public class JsonItemStorage : IItemStorageRepo
{

    public static string filePath = "Items.json";

    //If I find myself re-using the same string or object etc, I can go ahead
    //and make it a member of my class. This way I can reuse this same data without
    //having to continuously re-initialize it.
    //The underscore is a common convention to denote variables that are common
    //to the entire class


    //Changed my methods to be instance methods instead of class methods

    public void StoreItem(Item newItem)
    {
        List<Item?> existingItemsList = DTOStorage.DeserializeItem();

        //Once we deserialize our exisitng JSON text from the file into a new List<item> object
        //We will then simply add it to the list, using the Add() method
        existingItemsList.Add(newItem);

        DTOStorage.SerializeItem(existingItemsList);
    }

    public void StoreDocument(Document newDocument)
    {

        List<Document?> existingDocumentsList = DTOStorage.DeserializeDocument();


        //Once we deserialize our exisitng JSON text from the file into a new List<item> object
        //We will then simply add it to the list, using the Add() method
        existingDocumentsList.Add(newDocument);

        DTOStorage.SerializeDocument(existingDocumentsList);
    }

    public void StorePet(Pet newPet)
    {

        List<Pet?> existingPetsList = DTOStorage.DeserializePet();


        //Once we deserialize our exisitng JSON text from the file into a new List<item> object
        //We will then simply add it to the list, using the Add() method
        existingPetsList.Add(newPet);

        DTOStorage.SerializePet(existingPetsList);
    }
    
    public List<Item> GetItems(Guid userID, int listType)
    {
        List<Item> myReturnList = new();
        ItemsDTO allMyStuff = JsonSerializer.Deserialize<ItemsDTO>(File.ReadAllText(filePath));
        if (listType == 4 || listType == 1)
        {
            var userItems = allMyStuff.Items.Where(x => x.userId.Equals(userID));
            foreach (var item in userItems)
            {
                myReturnList.Add(item);
            }
        }
        if (listType == 4 || listType == 2)
        {
            var userPets = allMyStuff.Pets.Where(x => x.userId.Equals(userID));
            foreach (var pet in userPets)
            {
                myReturnList.Add(pet);
            }
        }
        if (listType == 4 || listType == 3)
        {
            var userDocs = allMyStuff.Documents.Where(x => x.userId.Equals(userID));
            foreach (var document in userDocs)
            {
                myReturnList.Add(document);
            }
        }
        return myReturnList;
    }

    public void ModifyItem(Item itemToBeModified, List<string> propertiesToBeModified)
    {

        // Read JSON file and deserialize into a list of User objects
        ItemsDTO allItems = JsonSerializer.Deserialize<ItemsDTO>(File.ReadAllText(filePath));
        

        allItems = DTOStorage.DeserializeAllItems();

        Item item = new();

        if(itemToBeModified.category == "Pet")
        {
             item = allItems.Pets.FirstOrDefault(i => i.itemId == itemToBeModified.itemId);
        }
        else if(itemToBeModified.category == "Document")
        {
             item = allItems.Documents.FirstOrDefault(i => i.itemId == itemToBeModified.itemId);
        }
        else
        {
             item = allItems.Items.FirstOrDefault(i => i.itemId == itemToBeModified.itemId);
        }

        foreach(string property in propertiesToBeModified)
        {
            if(property == "Description")
            {
                item.description = itemToBeModified.description;
            }
            else if(property == "Original Cost")
            {
                item.originalCost = itemToBeModified.originalCost;
            }
            else if(property == "Purchase Date")
            {
                item.purchaseDate = itemToBeModified.purchaseDate;
            }
        }

   
        // Serialize the updated list of User objects back to JSON
        string updatedJson = JsonSerializer.Serialize(allItems);

        // Write JSON back to file
        File.WriteAllText(filePath, updatedJson);
    }
    
}


