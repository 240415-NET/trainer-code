using TrackMyStuff.Controllers;
using TrackMyStuff.Models;

namespace TrackMyStuff.Presentation;

public class ItemMenu
{
    
    public static void ItemFunctionMenu (User user)
    {
        string userInput;
        bool validInput = false;

        Console.Clear();

        Console.Write("Please select from the following items:\n1. New Item\n2. Remove Item\n3. Modify\n4. View List of Items\n");
        try
        {
            do
            {
                userInput = Console.ReadLine().Trim().ToLower();
                switch (userInput)
                {
                    case "1":
                    case "1.":
                    case "1. new":
                    case "1. new item":
                    case "new":
                    case "new item":
                        validInput = true;
                        NewItem(user);
                        break;
                    case "2":
                    case "2.":
                    case "2. remove":
                    case "2. remove item":
                    case "remove":
                    case "remove item":
                        Console.WriteLine("This will be implemented later, sorry!");
                        break;
                    case "3":
                    case "3.":
                    case "3. modify":
                    case "3. modify item":
                    case "modify":
                    case "modify item":
                        Console.WriteLine("This will be implemented later, sorry!");
                        break;
                    case "4":
                    case "4.":
                    case "4. list":
                    case "4. list items":
                    case "list":
                    case "list items":
                        Console.WriteLine("This will be implemented later, sorry!");
                        break;
                }
            }
            while (validInput == false);
        }
        catch (Exception e){
            Console.WriteLine(e.Message);
        }
    }

    public static void NewItem (User user)
    {
        string category; 
        double originalCost; 
        DateTime purchaseDate; 
        string description;

        Console.Write("What is the category for the new item?\n1. Pet\n2. Document\n3. Other\n");
        category = Console.ReadLine().Trim();
        try
        {
            switch (category)
            {
                case "1":
                    NewPet(user);
                    break;
                case "2":
                    NewDocument(user);
                    break;
                case "3":
                    NewOther(user);
                    break;
                default:
                    break;
                }
        }
        catch (Exception e){
            Console.WriteLine(e.Message);
        }
    }

    public static void NewPet (User user)
    {

    }
    public static void NewDocument(User user)
    {

    }
    public static void NewOther(User user)
    {

    }
}