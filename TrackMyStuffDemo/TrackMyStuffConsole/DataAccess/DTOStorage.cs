using TrackMyStuff.Models;
using System.Text.Json;

namespace TrackMyStuff.Data;

public class DTOStorage
{
    public static string filePath = "Items.json";//will need final file name


    //Changed my methods to be instance methods instead of class methods

    public static List<Item> DeserializeItem()
    {
        //Console.WriteLine("Made it to deserialization!");
        List<Item?> existingItemList = new List<Item>();
        //String representing our file path and name. This can take just a file name,
        //Or it can take absolute or relative file paths. 
        //Filepaths begin at the root directory of the application, in our case the 
        //TrackMyStuff folder that holds our entire console app
        //Here we used a relative file path starting at TrackMyStuff to go into
        //Our DataAccess folder, and create the itemsFile.json inside that folder
        //string filePath = "itemsFile.json";

        //Console.WriteLine("Entered Storeitem()");
        //The try-catch prevents an error that occurs when attempting to deserialize the null list of objects from the DTO object.
        try
        {
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
                string existingDTOJson = File.ReadAllText(filePath);

                //Once you get the string from the file, THEN you can deserialize it.
                ItemsDTO existingDTO = JsonSerializer.Deserialize<ItemsDTO>(existingDTOJson);

                if (existingDTO.Items == null)
                    return existingItemList;
                else
                    existingItemList = existingDTO.Items.ToList(); //creating a list of exisiting items from DTO
            }
            else if (!File.Exists(filePath)) //The first time the program runs, the file probably doesn't exist
            {
                ItemsDTO existingDTO = new();
                string existingDTOJson = JsonSerializer.Serialize(existingDTO);
                File.WriteAllText(filePath, existingDTOJson);
            }
        }
        catch (Exception e) { }

        return existingItemList;

    }
    public static List<Document> DeserializeDocument()
    {

        //Console.WriteLine("Made it to deserialization!");
        List<Document?> existingDocumentList = new List<Document>();
        //The try-catch prevents an error that occurs when attempting to deserialize the null list of objects from the DTO object.
        try
        {
            //We want to create a JSON file from our method if one does not already exist
            if (File.Exists(filePath))
            {

                //Dont forget to read the actual string from the file BEFORE deserialization
                string existingDTOJson = File.ReadAllText(filePath);

                //Once you get the string from the file, THEN you can deserialize it.
                ItemsDTO existingDTO = JsonSerializer.Deserialize<ItemsDTO>(existingDTOJson);

                
                if (existingDTO.Documents == null)
                    return existingDocumentList;
                else
                    existingDocumentList = existingDTO.Documents.ToList(); //creating a list of exisiting items from DTO
                

            }
            else if (!File.Exists(filePath)) //The first time the program runs, the file probably doesn't exist
            {
                ItemsDTO existingDTO = new();
                string existingDTOJson = JsonSerializer.Serialize(existingDTO);
                File.WriteAllText(filePath, existingDTOJson);
            }
        }
        catch (Exception e) { }

        return existingDocumentList;

    }

    public static List<Pet> DeserializePet()
    {

        //Console.WriteLine("Made it to deserialization!");
        List<Pet?> existingPetList = new List<Pet>();
        //The try-catch prevents an error that occurs when attempting to deserialize the null list of objects from the DTO object.
        try
        {
            //We want to create a JSON file from our method if one does not already exist
            if (File.Exists(filePath))
            {

                string existingDTOJson = File.ReadAllText(filePath);

                //Once you get the string from the file, THEN you can deserialize it.
                ItemsDTO existingDTO = JsonSerializer.Deserialize<ItemsDTO>(existingDTOJson);

                //creating a list of exisiting items from DTO
                
                if (existingDTO.Pets == null)
                    return existingPetList;
                else
                    existingPetList = existingDTO.Pets.ToList(); //creating a list of exisiting items from DTO


            }
            else if (!File.Exists(filePath)) //The first time the program runs, the file probably doesn't exist
            {
                ItemsDTO existingDTO = new();
                string existingDTOJson = JsonSerializer.Serialize(existingDTO);
                File.WriteAllText(filePath, existingDTOJson);
            }
        }
        catch (Exception e) { }

        return existingPetList;

    }

    public static void SerializeItem(List<Item> existingItemList)
    {
        //Console.WriteLine("Made it to serialization!");
        //initialize DTO string from JSON file
        string existingDTOJson = File.ReadAllText(filePath);

        //Once you get the string from the file, THEN you can deserialize it.
        ItemsDTO existingDTO = JsonSerializer.Deserialize<ItemsDTO>(existingDTOJson);

        //replacing a list of exisiting items from DTO with new list
        existingDTO.Items = existingItemList;


        //Here we will serialize our list of users, into a JSON text string
        existingDTOJson = JsonSerializer.Serialize(existingDTO);

        //Now we will store our jsonUsersString to our file
        File.WriteAllText(filePath, existingDTOJson);
    }

    public static void SerializeDocument(List<Document> existingDocumentList)
    {
        //Console.WriteLine("Made it to serialization!");
        //initialize DTO string from JSON file
        string existingDTOJson = File.ReadAllText(filePath);

        //Once you get the string from the file, THEN you can deserialize it.
        ItemsDTO existingDTO = JsonSerializer.Deserialize<ItemsDTO>(existingDTOJson);

        //replacing a list of exisiting items from DTO with new list
        existingDTO.Documents = existingDocumentList;


        //Here we will serialize our list of users, into a JSON text string
        existingDTOJson = JsonSerializer.Serialize(existingDTO);

        //Now we will store our jsonUsersString to our file
        File.WriteAllText(filePath, existingDTOJson);
    }

    public static void SerializePet(List<Pet> existingPetList)
    {
        //Console.WriteLine("Made it to serialization!");
        //initialize DTO string from JSON file
        string existingDTOJson = File.ReadAllText(filePath);

        //Once you get the string from the file, THEN you can deserialize it.
        ItemsDTO existingDTO = JsonSerializer.Deserialize<ItemsDTO>(existingDTOJson);

        //replacing a list of exisiting items from DTO with new list
        existingDTO.Pets = existingPetList;


        //Here we will serialize our list of users, into a JSON text string
        existingDTOJson = JsonSerializer.Serialize(existingDTO);

        //Now we will store our jsonUsersString to our file
        File.WriteAllText(filePath, existingDTOJson);
    }
}