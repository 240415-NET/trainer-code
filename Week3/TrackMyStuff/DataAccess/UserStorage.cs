using TrackMyStuff.Models;
using System.Text.Json;

namespace TrackMyStuff.Data;

public class UserStorage 
{

    public static void StoreUser(User user)
    {   
        //String representing our file path and name. This can take just a file name,
        //Or it can take absolute or relative file paths. 
        string filePath = "UsersFile.json";

        //Creating a blank list to use later
        List<User> usersList = new List<User>();

        //We want to create a JSON file from our method if one does not already exist
        if(File.Exists(filePath))
        {
            //Here we will probably read the file for a collection of users, and then add our user
            //and rewrite the file
        }
        else if (!File.Exists(filePath)) //The first time the program runs, the file probably doesn't exist
        {
            //Adding our user to our list, PRIOR to serializing it
            usersList.Add(user);

            //Here we will serialize our list of users, into a JSON text string
            string jsonUsersListString = JsonSerializer.Serialize(usersList);

            //Now we will store our jsonUsersString to our file
            File.WriteAllText(filePath, jsonUsersListString);
            
        }


        //If it does, we want to append the object to the file
        
        // If it doesn't, create the file and store our object

    }




}