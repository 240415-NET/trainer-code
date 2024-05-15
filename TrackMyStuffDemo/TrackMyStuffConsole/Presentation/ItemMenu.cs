using TrackMyStuff.Controllers;
using TrackMyStuff.Models;

namespace TrackMyStuff.Presentation;

public class ItemMenu
{

    public static void ItemFunctionMenu(User user)
    {
        string userInput;
        bool validInput = false;

        Console.Clear();

        Console.Write("Please select from the following items:\n1. View List of Items\n2. New Item\n3. Remove Item\n4. Modify Item\n");
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
                        NewItem(user);
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
                        ModifyItemMenu(user);
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


    public static void NewItem(User user)
    {
        string category;
        double originalCost;
        DateTime purchaseDate;
        string description;
        bool entrySuccess = false;

        Console.Write("What is the category for the new item?\n1. Pet\n2. Document\n3. Other\n");
        do
        {
            category = Console.ReadLine().Trim();
            try
            {
                switch (category)
                {
                    case "1":
                        entrySuccess = true;
                        NewPet(user);
                        break;
                    case "2":
                        entrySuccess = true;
                        NewDocument(user);
                        break;
                    case "3":
                        entrySuccess = true;
                        NewOther(user);
                        break;
                    default:
                        Console.WriteLine("Please key a valid option");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        while (entrySuccess == false);

    }

    public static void NewPet(User user)
    {
        bool entrySuccess = false;
        do
        {
            try
            {
                string category;
                double originalCost;
                DateTime purchaseDate;
                string description;
                string name;
                string species;
                int age;

                //Console.WriteLine("Please enter the category for your item. (i.e. Furniture, Appliance, etc.)");
                category = "Pet";
                Console.WriteLine("What is the name of your pet?");
                name = Console.ReadLine().Trim();
                Console.WriteLine($"What species is {name}?");
                species = Console.ReadLine().Trim();
                Console.WriteLine($"What is {name}'s age?");
                age = int.Parse(Console.ReadLine().Trim());
                Console.WriteLine($"What was the original cost for {name}? Please enter just the number with no currency sign");
                originalCost = double.Parse(Console.ReadLine().Trim());
                Console.WriteLine($"What was the original purchase date of {name}? Please enter with proper formatting -- i.e. 12/25/2001");
                purchaseDate = DateTime.Parse(Console.ReadLine().Trim());
                Console.WriteLine($"Enter a description of {name}");
                description = Console.ReadLine().Trim();
                /*
                Console.WriteLine(category);
                Console.WriteLine(originalCost);
                Console.WriteLine(purchaseDate);
                Console.WriteLine(description);
                Console.WriteLine(name);
                Console.WriteLine(species);
                Console.WriteLine(age);
                */
                entrySuccess = true;
                ItemController.CreatePet(user, category, originalCost, purchaseDate, description, name, species, age);
            }
            catch (Exception e)
            {
                //Console.Clear();
                Console.WriteLine(e.Message);
                Console.WriteLine("Please key in a valid input!");
            }
        }
        while (entrySuccess == false);
    }
    public static void NewDocument(User user)
    {
        bool entrySuccess = false;
        do
        {
            try
            {
                string category;
                double originalCost;
                DateTime purchaseDate;
                string description;
                string documentType;
                DateTime expirationDate;

                category = "Document";
                Console.WriteLine("What type of document is this?");
                documentType = Console.ReadLine().Trim();
                Console.WriteLine("Enter a description of the document. (i.e. Ron's Will)");
                description = Console.ReadLine().Trim();
                Console.WriteLine("What was the original acquisition date of the document? Please enter with proper formatting -- i.e. 12/25/2001");
                purchaseDate = DateTime.Parse(Console.ReadLine().Trim());
                Console.WriteLine("What was the original cost for your document? Please enter just the number with no currency sign");
                originalCost = double.Parse(Console.ReadLine().Trim());
                Console.WriteLine("On what date will this document expire? Please enter with proper formatting -- i.e. 12/25/2001");
                expirationDate = DateTime.Parse(Console.ReadLine().Trim());
                /*
                Console.WriteLine(category);
                Console.WriteLine(originalCost);
                Console.WriteLine(purchaseDate);
                Console.WriteLine(description);
                Console.WriteLine(documentType);
                Console.WriteLine(expirationDate);
                */
                entrySuccess = true;
                ItemController.CreateDocument(user, category, originalCost, purchaseDate, description, documentType, expirationDate);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please key in a valid input!");
            }
        }
        while (entrySuccess == false);
    }
  
    public static void NewOther(User user)
    {
        //Need to add try-catch!
        bool entrySuccess = false;
        do
        {
            try
            {
                string category;
                double originalCost;
                DateTime purchaseDate;
                string description;

                Console.WriteLine("Please enter the category for your item. (i.e. Furniture, Appliance, etc.)");
                category = Console.ReadLine().Trim();
                Console.WriteLine("What was the original cost for your item? Please enter just the number with no currency sign");
                originalCost = double.Parse(Console.ReadLine().Trim());
                Console.WriteLine("What was the original purchase date of the item? Please enter with proper formatting -- i.e. 12/25/2001");
                purchaseDate = DateTime.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Enter a description of the item. (i.e. Brown sleeper sofa)");
                description = Console.ReadLine().Trim();
                entrySuccess = true;
                ItemController.CreateItem(user, category, originalCost, purchaseDate, description);
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("Please key in a valid input!");
            }
        }
        while (entrySuccess == false);
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

    public static void ModifyItemMenu(User user)
    {
        bool isValid = false;
        bool keepAlive = true;
        Item itemToBeModified = new();
        List<Item> modifyItemList = new();

        ViewAllItems(user.userId);



        //itemToBeModified = new Item(user.userId, "newCategory", 10.00, DateTime.Now, "Old description"); // PLACEHOLDER FOR TESTING TO BE REMOVED LATER

        do
        {
            Console.WriteLine(
            "Please select which item you'd like to modify, " +
            "or type 0 if you are finished.");
            try
            {
                int input = int.Parse(Console.ReadLine() ?? "");
                               
                //input -1 => Item // itemToBeModified = 
                //List<Item> usersItems returned from Team 2(?) method.
                //Func<int, Item> getItemAtIndex = index => items.ElementAtOrDefault(index);
                //itemToBeModified =  getItemAtIndex(input); 
       

                isValid = true;
                if (keepAlive = input != 0) // if 0 is entered, keepAlive will evaluate to false and skip this code block.
                {
                    ModifyIndividualItemDisplay(itemToBeModified, modifyItemList, user); //will remove user later
                }
            }
            catch
            {
                Console.WriteLine("You are so stupid!");
                isValid = false;
            }
        }
        while (!isValid || keepAlive);

        ModifyItems.ModifyItemsFromList(modifyItemList);

    }

    public static List<Item> ModifyIndividualItemDisplay(Item itemToBeModified, List<Item> modifyItemList, User user)
    {


        Console.WriteLine($"Current description: {itemToBeModified.description}");
        Console.WriteLine("Please enter the new description: ");
        string modifiedDescription = Console.ReadLine() ?? "";

        //Call a method to add the modifiedItem to a List ModifyItemController.
        ModifyItems.ModifyIndividualItem(itemToBeModified, modifiedDescription, modifyItemList);


        return modifyItemList;

    }

}