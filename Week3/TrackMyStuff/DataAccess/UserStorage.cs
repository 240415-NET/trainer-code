using TrackMyStuff.Models;
using System.Text.Json;

namespace TrackMyStuff.Data;

public class UserStorage 
{

    public static void StoreUser(User user)
    {   
        //String representing our file path and name. This can take just a file name,
        //Or it can take absolute or relative file paths. 
        //Filepaths begin at the root directory of the application, in our case the 
        //TrackMyStuff folder that holds our entire console app
        //Here we used a relative file path starting at TrackMyStuff to go into
        //Our DataAccess folder, and create the UsersFile.json inside that folder
        string filePath = "UsersFile.json";

        Console.WriteLine("Entered StoreUser()");

        //We want to create a JSON file from our method if one does not already exist
        if(File.Exists(filePath))
        {
            //We need to deserialize the existing json text string in our file, and store it in our list.
            Console.WriteLine("Entered IF FILE EXISTS logic block");
            //Here we will probably read the file for a collection of users, and then add our user
            //and rewrite the file
            //When we deserialize we have to be explicit with our type, the Deserialize method
            //NEEDS to know what kind of object it's going to create.

            //Dont forget to read the actual string from the file BEFORE deserialization
            string existingUsersJson = File.ReadAllText(filePath);

            //Once you get the string from the file, THEN you can deserialize it.
            List<User> existingUsersList = JsonSerializer.Deserialize<List<User>>(existingUsersJson);
            

            //Once we deserialize our exisitng JSON text from the file into a new List<User> object
            //We will then simply add it to the list, using the Add() method
            existingUsersList.Add(user);

            //Here we will serialize our list of users, into a JSON text string
            string jsonExistingUsersListString = JsonSerializer.Serialize(existingUsersList);

            //Now we will store our jsonUsersString to our file
            File.WriteAllText(filePath, jsonExistingUsersListString);

        }
        else if (!File.Exists(filePath)) //The first time the program runs, the file probably doesn't exist
        {
            //Creating a blank list to use later
            List<User> initialUsersList = new List<User>();

            //Adding our user to our list, PRIOR to serializing it
            initialUsersList.Add(user);

            //Here we will serialize our list of users, into a JSON text string
            string jsonUsersListString = JsonSerializer.Serialize(initialUsersList);

            //Now we will store our jsonUsersString to our file
            File.WriteAllText(filePath, jsonUsersListString);
        }


        //If it does, we want to append the object to the file
        
        // If it doesn't, create the file and store our object

    }




}