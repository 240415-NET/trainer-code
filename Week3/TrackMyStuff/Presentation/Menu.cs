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
                    case 1: // Creating a new user
                        
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
    
    
}