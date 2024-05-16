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
                        Console.WriteLine("This will be implemented later, sorry!");
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
                            myReturnedGuid = SortMenu(userID, 1, userChoice);
                            if (myReturnedGuid != Guid.Empty) { ViewSpecifiedItemDetails(userID, myReturnedGuid); }
                            break;
                        case 2:
                            myReturnedGuid = SortMenu(userID, 1, userChoice);
                            if (myReturnedGuid != Guid.Empty) { ViewSpecifiedItemDetails(userID, myReturnedGuid); }
                            break;
                        case 3:
                            myReturnedGuid = SortMenu(userID, 1, userChoice);
                            if (myReturnedGuid != Guid.Empty) { ViewSpecifiedItemDetails(userID, myReturnedGuid); }
                            break;
                        case 4:
                            myReturnedGuid = SortMenu(userID, 1, userChoice);
                            if (myReturnedGuid != Guid.Empty) { ViewSpecifiedItemDetails(userID, myReturnedGuid); }
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

    public static Guid SortMenu(Guid userID, int abbrList, int listType)
    {
        bool exitSortMenu = false;
        bool exitSortSubMenu = false;
        bool exitAscDescChoice = false;
        int sortBy = 0;
        int sortOrder = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("Do you want the items to be sorted? (y/n)");
            string userInput = (Console.ReadLine() ?? "").Trim();
            if (String.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("That was... nothing.  Spectacularly nothing. I need a number.");
                Console.ReadKey();
                exitSortMenu = false;
            }
            else if (userInput.ToLower() == "y") 
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("What would you like the list sorted by?");
                    Console.WriteLine("1. Category");
                    Console.WriteLine("2. Purchase Date");
                    Console.WriteLine("3. Original Cost");
                    Console.WriteLine("4. Description");
                    if (listType == 3)
                    {
                        Console.WriteLine("5. Name");
                        Console.WriteLine("6. Species");
                        Console.WriteLine("7. Age");
                    }
                    else if (listType == 4)
                    {
                        Console.WriteLine("5. Document Type");
                        Console.WriteLine("6. Expiration Date");
                    }
                    Console.WriteLine("0. View without sorting after all");
                    userInput = (Console.ReadLine() ?? "").Trim();
                    if (String.IsNullOrEmpty(userInput))
                    {
                        Console.WriteLine("That was... nothing.  Spectacularly nothing. I need a number.");
                        Console.ReadKey();
                        exitSortSubMenu = false;
                    }
                    else
                    {
                        try
                        {
                            int userChoice = Convert.ToInt32(userInput);
                            if (userChoice == 0)
                            {
                                exitSortSubMenu = true;
                                exitSortMenu = true;
                            }
                            else if (userChoice > 0 && listType > 0 && ((listType < 2 && userChoice <= 4) || (listType == 3 && userChoice <= 7) || (listType == 4 && userChoice <= 6)))
                            {
                                sortBy = userChoice;
                                exitSortSubMenu = true;
                            }
                            else
                            {
                                Console.WriteLine("That didn't make any sense.  Pick one of the numbers presented as an option.");
                                exitSortSubMenu = false;
                            }

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine(e.StackTrace.ToString());
                            Console.ReadKey();
                        }
                    }

                } while (!exitSortSubMenu);
                do
                {
                    Console.Clear();
                    Console.WriteLine("In what order would you like the list to be sorted?");
                    Console.WriteLine("1. Ascending");
                    Console.WriteLine("2. Descending");
                    userInput = (Console.ReadLine() ?? "").Trim();
                    if (String.IsNullOrEmpty(userInput))
                    {
                        Console.WriteLine("That was... nothing.  Spectacularly nothing. I need a number. Specifically a 1 or a 2.");
                        Console.ReadKey();
                        exitSortSubMenu = false;
                    }
                    else
                    {
                        try
                        {
                            int sortChoice = Convert.ToInt32(userInput);
                            if(sortChoice == 1)
                            {
                                sortOrder = 0;
                                exitAscDescChoice = true;
                            }
                            else if(sortChoice == 2)
                            {
                                sortOrder = 1;
                                exitAscDescChoice = true;
                            }
                            else
                            {
                                Console.WriteLine("Your options are 1 or 2. Enter one of those two numbers. Please.");
                                exitAscDescChoice = false;
                                Console.ReadKey();
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine("Try entering a 1 or a 2 and just that...");
                            exitAscDescChoice= false;
                            Console.ReadKey();
                        }
                    }

                }while(!exitAscDescChoice);
            }
            switch (listType)
            {
                case 1:
                    return ViewAllItems(userID, abbrList, sortBy: sortBy, sortOrder: sortOrder);
                case 2:
                    return ViewMyItems(userID, abbrList, sortBy: sortBy, sortOrder: sortOrder);
                case 3:
                    return ViewMyPets(userID, abbrList, sortBy: sortBy, sortOrder: sortOrder);
                case 4:
                    return ViewMyDocuments(userID, abbrList, sortBy: sortBy, sortOrder: sortOrder);
            }
        } while (!exitSortMenu);
        return Guid.Empty;
    }
    public static Guid ViewAllItems(Guid userID, int abbreviatedList = 0, string messageToUser = "Which item would you like to view?", int sortBy = 0, int sortOrder = 0)
    {
        List<Item> allMyItems = ItemController.GetAllItems(userID);
        if (allMyItems.Count() < 1)
        {
            Console.WriteLine("You have nothing...");
            Console.ReadKey();
        }
        else
        {
            if (sortBy != 0)
            {
                allMyItems = SortMyItems(allMyItems, sortBy, sortOrder);

            }
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

    public static Guid ViewMyItems(Guid userID, int abbreviatedList = 0, string messageToUser = "Which item would you like to view?", int sortBy = 0, int sortOrder = 0)
    {
        List<Item> allMyItems = ItemController.GetItems(userID);
        if (allMyItems.Count() < 1)
        {
            Console.WriteLine("You have nothing...");
            Console.ReadKey();
        }
        else
        {
            if (sortBy != 0)
            {
                allMyItems = SortMyItems(allMyItems, sortBy, sortOrder);

            }
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

    public static Guid ViewMyPets(Guid userID, int abbreviatedList = 0, string messageToUser = "Which item would you like to view?", int sortBy = 0, int sortOrder = 0)
    {
        List<Pet> allMyPets = ItemController.GetPets(userID);
        if (allMyPets.Count() < 1)
        {
            Console.WriteLine("You have nothing...");
            Console.ReadKey();
        }
        else
        {
            if (sortBy != 0)
            {
                allMyPets = SortMyPets(allMyPets, sortBy, sortOrder);

            }
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

    public static Guid ViewMyDocuments(Guid userID, int abbreviatedList = 0, string messageToUser = "Which item would you like to view?", int sortBy = 0, int sortOrder = 0)
    {
        List<Document> allMyDocuments = ItemController.GetDocuments(userID);
        if (allMyDocuments.Count() < 1)
        {
            Console.WriteLine("You have nothing...");
            Console.ReadKey();
        }
        else
        {
            if (sortBy != 0)
            {
                allMyDocuments = SortMyDocuments(allMyDocuments, sortBy, sortOrder);

            }
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

    public static List<Item> SortMyItems(List<Item> listToSort, int sortBy, int sortOrder)
    {

        switch (sortBy)
        {
            case 1:
                if (sortOrder == 0)
                {
                    return listToSort.OrderBy(x => x.category).ToList();
                }
                else
                {
                    return listToSort.OrderByDescending(x => x.category).ToList();
                }
            case 2:
                if (sortOrder == 0)
                {
                    return listToSort.OrderBy(x => x.purchaseDate).ToList();
                }
                else
                {
                    return listToSort.OrderByDescending(x => x.purchaseDate).ToList();
                }
            case 3:
                if (sortOrder == 0)
                {
                    return listToSort.OrderBy(x => x.originalCost).ToList();
                }
                else
                {
                    return listToSort.OrderByDescending(x => x.originalCost).ToList();
                }
            case 4:
                if (sortOrder == 0)
                {
                    return listToSort.OrderBy(x => x.description).ToList();
                }
                else
                {
                    return listToSort.OrderByDescending(x => x.description).ToList();
                }
            default:
                return listToSort;
        }
    }

    public static List<Pet> SortMyPets(List<Pet> listToSort, int sortBy, int sortOrder)
    {
        switch (sortBy)
        {
            case 1:
                if (sortOrder == 0)
                {
                    return listToSort.OrderBy(x => x.category).ToList();
                }
                else
                {
                    return listToSort.OrderByDescending(x => x.category).ToList();
                }
            case 2:
                if (sortOrder == 0)
                {
                    return listToSort.OrderBy(x => x.purchaseDate).ToList();
                }
                else
                {
                    return listToSort.OrderByDescending(x => x.purchaseDate).ToList();
                }
            case 3:
                if (sortOrder == 0)
                {
                    return listToSort.OrderBy(x => x.originalCost).ToList();
                }
                else
                {
                    return listToSort.OrderByDescending(x => x.originalCost).ToList();
                }
            case 4:
                if (sortOrder == 0)
                {
                    return listToSort.OrderBy(x => x.description).ToList();
                }
                else
                {
                    return listToSort.OrderByDescending(x => x.description).ToList();
                }
            case 5:
                if (sortOrder == 0)
                {
                    return listToSort.OrderBy(x => x.name).ToList();
                }
                else
                {
                    return listToSort.OrderByDescending(x => x.name).ToList();
                }
            case 6:
                if (sortOrder == 0)
                {
                    return listToSort.OrderBy(x => x.species).ToList();
                }
                else
                {
                    return listToSort.OrderByDescending(x => x.species).ToList();
                }
            case 7:
                if (sortOrder == 0)
                {
                    return listToSort.OrderBy(x => x.age).ToList();
                }
                else
                {
                    return listToSort.OrderByDescending(x => x.age).ToList();
                }
            default:
                return listToSort;
        }
    }

    public static List<Document> SortMyDocuments(List<Document> listToSort, int sortBy, int sortOrder)
    {
        switch (sortBy)
        {
            case 1:
                if (sortOrder == 0)
                {
                    return listToSort.OrderBy(x => x.category).ToList();
                }
                else
                {
                    return listToSort.OrderByDescending(x => x.category).ToList();
                }
            case 2:
                if (sortOrder == 0)
                {
                    return listToSort.OrderBy(x => x.purchaseDate).ToList();
                }
                else
                {
                    return listToSort.OrderByDescending(x => x.purchaseDate).ToList();
                }
            case 3:
                if (sortOrder == 0)
                {
                    return listToSort.OrderBy(x => x.originalCost).ToList();
                }
                else
                {
                    return listToSort.OrderByDescending(x => x.originalCost).ToList();
                }
            case 4:
                if (sortOrder == 0)
                {
                    return listToSort.OrderBy(x => x.description).ToList();
                }
                else
                {
                    return listToSort.OrderByDescending(x => x.description).ToList();
                }
            case 5:
                if (sortOrder == 0)
                {
                    return listToSort.OrderBy(x => x.documentType).ToList();
                }
                else
                {
                    return listToSort.OrderByDescending(x => x.documentType).ToList();
                }
            case 6:
                if (sortOrder == 0)
                {
                    return listToSort.OrderBy(x => x.expirationDate).ToList();
                }
                else
                {
                    return listToSort.OrderByDescending(x => x.expirationDate).ToList();
                }
            default:
                return listToSort;
        }
    }
}