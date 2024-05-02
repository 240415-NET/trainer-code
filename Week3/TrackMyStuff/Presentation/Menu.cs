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
                        
                        break;
                    case 2:
                        
                        break;

                    case 3: //User chooses to exit the program
                        return; //This return exits this method, and returns us to where it was called.

                    default: // If the user enters an integer that is not 1, 2, or 3
                        Console.WriteLine("Please enter a valid choice!");
                        validInput = false;
                        break;
                }

            }
            catch (Exception ex) 
            {   
                validInput = false;
                Console.WriteLine("Please enter a valid choice!");
            }

        } while (!validInput);

        
    }

    //This method handles the prompts for creating a new user profile
    public static void UserCreationMenu() 
    {
        //We want to ask for a user name

        //We want to make sure the user did not just hit enter and provide an empty string

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

        do
        {
            Console.WriteLine("Please enter a username: ");

            
        } while (!validInput); //Continue running the above block UNTIL input is valid

    }
    
    
}