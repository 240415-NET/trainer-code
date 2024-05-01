namespace TrackMyStuff.Presentation;

public class Menu
{
   
    public static void StartMenu() {

        int userChoice = 0;

        Console.WriteLine("Welcome to TrackMyStuff!");
        Console.WriteLine("1. New user");
        Console.WriteLine("2. Returning user");
        Console.WriteLine("3. Exit program");
        
        //Setting up the try-catch to handle user input
        try
        {

        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.StackTrace.ToString());
        }

    }
    
    
}