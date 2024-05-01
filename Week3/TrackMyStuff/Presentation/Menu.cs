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