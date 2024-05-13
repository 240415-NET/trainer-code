using TrackMyStuff.Models;
using System.Text.Json;

namespace TrackMyStuff.Data;

public class JsonItemStorage : IItemStorageRepo
{
    public static string filePath = "Items.json";


    //Changed my methods to be instance methods instead of class methods

    public void StoreItem(Item newItem)
    {
        //String representing our file path and name. This can take just a file name,
        //Or it can take absolute or relative file paths. 
        //Filepaths begin at the root directory of the application, in our case the 
        //TrackMyStuff folder that holds our entire console app
        //Here we used a relative file path starting at TrackMyStuff to go into
        //Our DataAccess folder, and create the itemsFile.json inside that folder
        //string filePath = "itemsFile.json";

        //Console.WriteLine("Entered Storeitem()");

        //We want to create a JSON file from our method if one does not already exist
        if (File.Exists(filePath))
        {
            //We need to deserialize the existing json text string in our file, and store it in our list.
            //Console.WriteLine("Entered IF FILE EXISTS logic block");

            //Here we will probably read the file for a collection of items, and then add our item
            //and rewrite the file
            //When we deserialize we have to be explicit with our type, the Deserialize method
            //NEEDS to know what kind of object it's going to create.

            //Dont forget to read the actual string from the file BEFORE deserialization
            string existingItemsJson = File.ReadAllText(filePath);

            //Once you get the string from the file, THEN you can deserialize it.
            ItemsDTO existingLists = JsonSerializer.Deserialize<ItemsDTO>(existingItemsJson);


            //Once we deserialize our exisitng JSON text from the file into a new List<item> object
            //We will then simply add it to the list, using the Add() method
            if (newItem.GetType() == typeof(Pet))
            {
                existingLists.Pets.Add((Pet)newItem);
            }
            else if (newItem.GetType() == typeof(Document))
            {
                existingLists.Documents.Add((Document)newItem);
            }
            else
            {
                existingLists.Items.Add(newItem);
            }

            //Here we will serialize our list of items, into a JSON text string
            string jsonExistingItemsListString = JsonSerializer.Serialize(existingLists);

            //Now we will store our jsonitemsString to our file
            File.WriteAllText(filePath, jsonExistingItemsListString);

        }
        else if (!File.Exists(filePath)) //The first time the program runs, the file probably doesn't exist
        {
            //Creating a blank list to use later
            List<Item> itemsList = new List<Item>();
            List<Pet> petsList = new List<Pet>();
            List<Document> documentsList = new List<Document>();

            ItemsDTO myItems = new();

            if (newItem.GetType() == typeof(Pet))
            {
                myItems.Pets.Add((Pet)newItem);
            }
            else if (newItem.GetType() == typeof(Document))
            {
                myItems.Documents.Add((Document)newItem);
            }
            else
            {
                myItems.Items.Add(newItem);
            }
            // DateTime testing = DateTime.Now;
            // Pet mine = new Pet(userGUID,"pet",10,testing,"cat","thing","mutt",6);     
            // Document doc = new Document(userGUID,"paper",.01,testing,"it's paper!","the paper kind",testing);
            // Item item = new Item(userGUID,"thing",5,testing,"no");
            // myItems.Items.Add(item);
            // myItems.Pets.Add(mine);
            // myItems.Documents.Add(doc);

            // myItems.Items = itemsList;
            // myItems.Pets = petsList;
            // myItems.Documents = documentsList;

            //Here we will serialize our list of items, into a JSON text string
            string jsonItemsListString = JsonSerializer.Serialize(myItems);

            //Now we will store our jsonitemsString to our file
            File.WriteAllText(filePath, jsonItemsListString);
        }

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
}
