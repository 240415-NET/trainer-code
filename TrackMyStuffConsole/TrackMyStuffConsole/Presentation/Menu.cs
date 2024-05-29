using TrackMyStuff.Controllers;
using TrackMyStuff.Models;

namespace TrackMyStuff.Presentation;

public class Menu
{
   
   //This method displays the initial menu when the user runs the program
    public static void StartMenu() {

        int userChoice = 0;
        bool validInput = true;

        Console.WriteLine("Welcome to TrackMyStuff!");
        Console.WriteLine("1. New user");
        Console.WriteLine("2. Returning user");
        Console.WriteLine("3. Exit program");
        
        //Setting up the try-catch to handle user input with
        //do-while to let them try again
        do
        {
            try
            {
                userChoice = Convert.ToInt32(Console.ReadLine());
                validInput = true;

                switch (userChoice)
                {
                    case 1: // Creating a new user profile
                        UserCreationMenu();
                        break;
                    case 2:
                        UserLoginMenu();
                       
                        break;

                    case 3: //User chooses to exit the program
                        return; //This return exits this method, and returns us to where it was called.

                    default: // If the user enters an integer that is not 1, 2, or 3
                        Console.WriteLine("Please enter a valid choice (from the default)!");
                        validInput = false;
                        break;
                }

            }
            catch (Exception ex) 
            {   
                validInput = false;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Please enter a valid choice! (from the catch)");
            }

        } while (!validInput);

        
    }

    //This method handles the prompts for creating a new user profile
    public static void UserCreationMenu() 
    {
        //We want to ask for a user name

        //We want to make sure the user did not just hit enter and provide a null or empty string

        //We want to call the Controller's UserExists() method to see if a given username is already taken

        //If it is taken, we prompt the user to try again with a new username. 

        //Pass the username to the controller

        /*
            Lets sketch out the logic here

            We are going to need a boolean "flag" 

            do-while loop checking against our flag
                {
                    check if the given input is null or empty
                        if-else to check if our input is null or empty
                    
                    assuming our input is valid according to our business rules (since we set 
                    the requirement that you cannot have a blank username)

                    we then want to check if a given username exists using the UserExists method 
                    in the UserController
                        if the name isn't taken, great
                        if the name IS taken, then prompt the user to try again
                } 
            We stay in the do-while until the input passes both checks.
        */

        //Declaring our flag boolean outside of our loop, setting it to true
        bool validInput = true;
        string userInput = "";

        do
        {   
            //Prompting the user for a username
            Console.WriteLine("Please enter a username: ");

            //The ?? is called the null-coalescing operator
            //If the input comes back null, then we manually set it to an empty string - to avoid 
            //the possibility of this userInput string ever being null. 
            userInput = Console.ReadLine() ?? "";

            //Here we are going to trim the string, to remove any leading or trailing spaces
            userInput = userInput.Trim();

            //If else to check both of our conditions - empty string and existing username
            if(String.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Username cannot be blank, please try again.");
                validInput = false;
            }else if(UserController.UserExists(userInput))
            {
                Console.WriteLine("Username already exists, please choose another.");
                validInput = false;
            }else{ //If neither check trips we simply call CreateUser from the UserController!
                UserController.CreateUser(userInput);
                Console.WriteLine("Profile created!");
                validInput = true;
                User user = UserController.ReturnUser(userInput);
                ItemMenu.ItemFunctionMenu(user);
            }

        } while (!validInput); //Continue running the above block UNTIL input is valid

    }


public static void UserLoginMenu() 
    {
 
        //Declaring our flag boolean outside of our loop, setting it to true
        bool validInput = true;
        string userInput = "";

        do
        {   
            //Prompting the user for a username
            Console.WriteLine("Please enter a username: ");

            //The ?? is called the null-coalescing operator
            //If the input comes back null, then we manually set it to an empty string - to avoid 
            //the possibility of this userInput string ever being null. 
            userInput = Console.ReadLine() ?? "";

            //Here we are going to trim the string, to remove any leading or trailing spaces
            userInput = userInput.Trim();

            //If else to check both of our conditions - empty string and existing username
            if(String.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Username cannot be blank, please try again.");
                validInput = false;
            }else if(!UserController.UserExists(userInput)) //if User doesn't exist
            {
                Console.WriteLine("Username doesn't exist, please choose another.");
                validInput = false;
            }else{ //If neither check trips we simply call CreateUser from the UserController!
                User existingUser = UserController.ReturnUser(userInput);
                Console.WriteLine("You're logged in!");
                Console.WriteLine($"Username: {existingUser.userName}");
                Console.WriteLine($"User Id: {existingUser.userId}");
                validInput = true;
                ItemMenu.ItemFunctionMenu(existingUser); //new line for calling item functionality menu
            }

        } while (!validInput); //Continue running the above block UNTIL input is valid

    }


    
    
}