using TrackMyStuff.Models;
using System.Text.Json;

namespace TrackMyStuff.Data;

public class JsonUserStorage : IUserStorageRepo
{
    //If I find myself re-using the same string or object etc, I can go ahead
    //and make it a member of my class. This way I can reuse this same data without
    //having to continuously re-initialize it.
    //The underscore is a common convention to denote variables that are common
    //to the entire class
    public static string filePath = "UsersFile.json";

    //Changed my methods to be instance methods instead of class methods

    public void StoreUser(User user)
    {   
        //String representing our file path and name. This can take just a file name,
        //Or it can take absolute or relative file paths. 
        //Filepaths begin at the root directory of the application, in our case the 
        //TrackMyStuff folder that holds our entire console app
        //Here we used a relative file path starting at TrackMyStuff to go into
        //Our DataAccess folder, and create the UsersFile.json inside that folder
        //string filePath = "UsersFile.json";

        //Console.WriteLine("Entered StoreUser()");

        //We want to create a JSON file from our method if one does not already exist
        if(File.Exists(filePath))
        {
            //We need to deserialize the existing json text string in our file, and store it in our list.
            //Console.WriteLine("Entered IF FILE EXISTS logic block");
            
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

    }

    public User FindUser(string usernameToFind)
    {
        //User object to store a user if they are found or NULL if they are not
        User foundUser = new User();

        try{

            //First, read the string back from our .json file
            string existingUsersJson = File.ReadAllText(filePath);

            //Then, we need to serialize the string back into a List of User objects
            List<User> existingUsersList = JsonSerializer.Deserialize<List<User>>(existingUsersJson);

            //Then, we need to check if there is a user object with the given username 
            //that came in as an argument when the method was called inside of our list
            //To do this we are going to use a LINQ method to query our collection called FirstOrDefault()
            //Inside the parenthesis is a lambda method or anonymous function 
            //Lambda expressions have the same basic syntax ((parameters) => expression_or_statement_block)

            //This => is called the lambda operator - so it is not actually functioning as any sort of 
            //comparator 

            //To the left of the => (lambda operator) is the input to our anonymous function or method
            //To the right, is the code that will be executed or evaluated against when the lambda runs
            foundUser = existingUsersList.FirstOrDefault(user => user.userName == usernameToFind);

            //The above lambda function is essentially iterating through and querying the list for us, 
            //as if we were doing the foreach loop below
            // foreach (User user in existingUsersList){
            //     if(user.userName == usernameToFind)
            //     {
            //         return user;
            //     }
            // }

            //If it exists, return that user
            

            //If it doesn't... do something else 


        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
        return foundUser;

    }

}