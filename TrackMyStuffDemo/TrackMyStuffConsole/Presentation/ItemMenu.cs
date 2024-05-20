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

        Console.WriteLine("Please select from the following items:\n1. View List of Items\n2. New Item\n3. Remove Item\n4. Modify Item\n5. Exit Program");
        try
        {
            do
            {
                userInput = Console.ReadLine().Trim().ToLower();
                switch (userInput)
                {
                    case "1":
                    case "1.":
                    case "1. list":
                    case "1. list items":
                    case "list":
                    case "list items":
                        ViewItemMenu(user.userId);
                        validInput = true;
                        break;
                    case "2":
                    case "2.":
                    case "2. new":
                    case "2. new item":
                    case "new":
                    case "new item":
                        validInput = true;
                        NewItemMenu.NewItem(user);
                        break;
                    case "3":
                    case "3.":
                    case "3. remove":
                    case "3. remove item":
                    case "remove":
                    case "remove item":
                        Console.WriteLine("This will be implemented later, sorry!");
                        break;
                    case "4":
                    case "4.":
                    case "4. modify":
                    case "4. modify item":
                    case "modify":
                    case "modify item":
                        Console.WriteLine("This will be implemented later, sorry!");
                        break;
                    case "5":
                    case "5.":
                    case "5. exit":
                    case "5. exit program":
                    case "exit":
                    case "exit program":
                        Console.WriteLine("Thank you for using \"TrackMyStuff\"");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please key valid option");
                        break;
                }
            }
            while (validInput == false);
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

  
    public static void ViewItemMenu(Guid userID)
    {
        Guid myReturnedGuid;
        bool exitViewMenu = false;
        do
        {
            Console.Clear();
            Console.WriteLine("What would you like to see?");
            Console.WriteLine("1. View All of my Stuff");
            Console.WriteLine("2. View my Items");
            Console.WriteLine("3. View my Pets");
            Console.WriteLine("4. View my Documents");
            Console.WriteLine("5. Back to Main Menu");
            string userInput = (Console.ReadLine() ?? "").Trim();
            if (String.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("That was... nothing.  Spectacularly nothing. I need a number.");
                Console.ReadKey();
                exitViewMenu = false;
            }
            else
            {
                try
                {
                    int userChoice = Convert.ToInt32(userInput);
                    switch (userChoice)
                    {
                        case 1:
                            myReturnedGuid = ViewAllItems(userID, 1);
                            if(myReturnedGuid != Guid.Empty){ViewSpecifiedItemDetails(userID,myReturnedGuid);}
                            break;
                        case 2:
                            myReturnedGuid = ViewMyItems(userID, 1);
                            if(myReturnedGuid != Guid.Empty){ViewSpecifiedItemDetails(userID,myReturnedGuid);}
                            break;
                        case 3:
                            myReturnedGuid = ViewMyPets(userID, 1);
                            if(myReturnedGuid != Guid.Empty){ViewSpecifiedItemDetails(userID,myReturnedGuid);}
                            break;
                        case 4:
                            myReturnedGuid = ViewMyDocuments(userID, 1);
                            if(myReturnedGuid != Guid.Empty){ViewSpecifiedItemDetails(userID,myReturnedGuid);}
                            break;
                        case 5:
                            exitViewMenu = true;
                            break;
                        default:
                            Console.WriteLine("I have no idea what you want. Try again.");
                            Console.ReadKey();
                            exitViewMenu = false;
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace.ToString());
                    Console.ReadKey();
                }
            }
        } while (!exitViewMenu);
    }

    public static Guid ViewAllItems(Guid userID, int abbreviatedList = 0, string messageToUser = "Which item would you like to view?")
    {
        List<Item> allMyItems = ItemController.GetAllItems(userID);
        if (allMyItems.Count() < 1)
        {
            Console.WriteLine("You have nothing...");
            Console.ReadKey();
        }
        else
        {
            bool exitView = false;
            do
            {
                Console.Clear();
                int loopCount = 1;
                foreach (Item item in allMyItems)
                {
                    if (abbreviatedList == 0)
                    {
                        Console.WriteLine(item);
                    }
                    else
                    {
                        Console.WriteLine($"{loopCount}: {item.AbbrToString()}");
                    }
                    loopCount++;
                }
                Console.WriteLine($"{loopCount}: Exit");
                Console.WriteLine(messageToUser);
                string userInput = (Console.ReadLine() ?? "").Trim();
                try
                {
                    int userChoice = Convert.ToInt32(userInput);
                    if (userChoice == loopCount)
                    {
                        exitView = true;
                    }
                    else if (userChoice <= allMyItems.Count() && userChoice > 0)
                    {
                        return allMyItems[userChoice - 1].itemId;
                    }
                    else
                    {
                        Console.WriteLine("Wut? Pick a number from the list");
                        Console.ReadKey();
                        exitView = false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Try picking a NUMBER from the provided list.");
                    Console.ReadKey();
                    exitView = false;
                }
            } while (!exitView);
        }
        return Guid.Empty;
    }
  
    public static Guid ViewMyItems(Guid userID, int abbreviatedList = 0, string messageToUser = "Which item would you like to view?")
    {
        List<Item> allMyItems = ItemController.GetItems(userID);
        if (allMyItems.Count() < 1)
        {
            Console.WriteLine("You have nothing...");
            Console.ReadKey();
        }
        else
        {
            bool exitView = false;
            do
            {
                Console.Clear();
                int loopCount = 1;
                foreach (Item item in allMyItems)
                {
                    if (abbreviatedList == 0)
                    {
                        Console.WriteLine(item);
                    }
                    else
                    {
                        Console.WriteLine($"{loopCount}: {item.AbbrToString()}");
                    }
                    loopCount++;
                }
                Console.WriteLine($"{loopCount}: Exit");
                Console.WriteLine(messageToUser);
                string userInput = (Console.ReadLine() ?? "").Trim();
                try
                {
                    int userChoice = Convert.ToInt32(userInput);
                    if (userChoice == loopCount)
                    {
                        exitView = true;
                    }
                    else if (userChoice <= allMyItems.Count() && userChoice > 0)
                    {
                        return allMyItems[userChoice - 1].itemId;
                    }
                    else
                    {
                        Console.WriteLine("Wut? Pick a number from the list");
                        exitView = false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Try picking a NUMBER from the provided list.");
                    exitView = false;
                }
            } while (!exitView);
        }
        return Guid.Empty;
    }
  
    public static Guid ViewMyPets(Guid userID, int abbreviatedList = 0, string messageToUser = "Which item would you like to view?")
    {
        List<Pet> allMyPets = ItemController.GetPets(userID);
        if (allMyPets.Count() < 1)
        {
            Console.WriteLine("You have nothing...");
            Console.ReadKey();
        }
        else
        {
            bool exitView = false;
            do
            {
                Console.Clear();
                int loopCount = 1;
                foreach (Item item in allMyPets)
                {
                    if (abbreviatedList == 0)
                    {
                        Console.WriteLine(item);
                    }
                    else
                    {
                        Console.WriteLine($"{loopCount}: {item.AbbrToString()}");
                    }
                    loopCount++;
                }
                Console.WriteLine($"{loopCount}: Exit");
                Console.WriteLine(messageToUser);
                string userInput = (Console.ReadLine() ?? "").Trim();
                try
                {
                    int userChoice = Convert.ToInt32(userInput);
                    if (userChoice == loopCount)
                    {
                        exitView = true;
                    }
                    else if (userChoice <= allMyPets.Count() && userChoice > 0)
                    {
                        return allMyPets[userChoice - 1].itemId;
                    }
                    else
                    {
                        Console.WriteLine("Wut? Pick a number from the list");
                        exitView = false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Try picking a NUMBER from the provided list.");
                    exitView = false;
                }
            } while (!exitView);
        }
        return Guid.Empty;
    }
  
    public static Guid ViewMyDocuments(Guid userID, int abbreviatedList = 0, string messageToUser = "Which item would you like to view?")
    {
        List<Document> allMyDocuments = ItemController.GetDocuments(userID);
        if (allMyDocuments.Count() < 1)
        {
            Console.WriteLine("You have nothing...");
            Console.ReadKey();
        }
        else
        {
            bool exitView = false;
            do
            {
                Console.Clear();
                int loopCount = 1;
                foreach (Item item in allMyDocuments)
                {
                    if (abbreviatedList == 0)
                    {
                        Console.WriteLine(item);
                    }
                    else
                    {
                        Console.WriteLine($"{loopCount}: {item.AbbrToString()}");
                    }
                    loopCount++;
                }
                Console.WriteLine($"{loopCount}: Exit");
                Console.WriteLine(messageToUser);
                string userInput = (Console.ReadLine() ?? "").Trim();
                try
                {
                    int userChoice = Convert.ToInt32(userInput);
                    if (userChoice == loopCount)
                    {
                        exitView = true;
                    }
                    else if (userChoice <= allMyDocuments.Count() && userChoice > 0)
                    {
                        return allMyDocuments[userChoice - 1].itemId;
                    }
                    else
                    {
                        Console.WriteLine("Wut? Pick a number from the list");
                        exitView = false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Try picking a NUMBER from the provided list.");
                    exitView = false;
                }
            } while (!exitView);
        }
        return Guid.Empty;
    }
  
    public static void ViewSpecifiedItemDetails(Guid userID, Guid itemID)
    {
        List<Item> allMyItems = ItemController.GetAllItems(userID);
        Console.Clear();
        var SpecificItem = allMyItems.Where(x => x.itemId.Equals(itemID));
        foreach (var thing in SpecificItem)
        {
            Console.WriteLine(thing);
        }
        Console.ReadKey();
    }
}