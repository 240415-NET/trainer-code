using TrackMyStuff.Models;
using System.Text.Json;

namespace TrackMyStuff.Data;

public class JsonItemStorage : IItemStorageRepo
{
    //If I find myself re-using the same string or object etc, I can go ahead
    //and make it a member of my class. This way I can reuse this same data without
    //having to continuously re-initialize it.
    //The underscore is a common convention to denote variables that are common
    //to the entire class
    public static string filePath = "ItemsFile.json";


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
        if(File.Exists(filePath))
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
            List<Item> existingItemsList = JsonSerializer.Deserialize<List<Item>>(existingItemsJson);
            

            //Once we deserialize our exisitng JSON text from the file into a new List<item> object
            //We will then simply add it to the list, using the Add() method
            existingItemsList.Add(newItem);

            //Here we will serialize our list of items, into a JSON text string
            string jsonExistingItemsListString = JsonSerializer.Serialize(existingItemsList);

            //Now we will store our jsonitemsString to our file
            File.WriteAllText(filePath, jsonExistingItemsListString);

        }
        else if (!File.Exists(filePath)) //The first time the program runs, the file probably doesn't exist
        {
            //Creating a blank list to use later
            List<Item> initialItemsList = new List<Item>();

            //Adding our item to our list, PRIOR to serializing it
            initialItemsList.Add(newItem);

            //Here we will serialize our list of items, into a JSON text string
            string jsonItemsListString = JsonSerializer.Serialize(initialItemsList);

            //Now we will store our jsonitemsString to our file
            File.WriteAllText(filePath, jsonItemsListString);
        }

    }
}