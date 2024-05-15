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
                        Console.WriteLine("This will be implemented later, sorry!");
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
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void NewPet(User user)
    {

    }
    public static void NewDocument(User user)
    {

    }
    public static void NewOther(User user)
    {
        //Need to add try-catch!

        string category;
        double originalCost;
        DateTime purchaseDate;
        string description;

        Console.WriteLine("Please enter the category for your item. (i.e. Furniture, Appliance, etc.)");
        category = Console.ReadLine().Trim();
        Console.WriteLine("What was the original cost for your item? Please enter just the number with no currency sign");
        originalCost = double.Parse(Console.ReadLine().Trim());
        Console.WriteLine("What was the original purchase date of the item?");
        purchaseDate = DateTime.Parse(Console.ReadLine().Trim());
        Console.WriteLine("Enter a description of the item. (i.e. Brown sleeper sofa)");
        description = Console.ReadLine().Trim();

        ItemController.CreateItem(user, category, originalCost, purchaseDate, description);
    }

    public static void ModifyItemMenu(User user)
    {
        bool isValid = false;
        bool keepAlive = true;
        Item itemToBeModified = new();
        List<Item> modifyItemList = new();



        itemToBeModified = new Item(user.userId, "newCategory", 10.00, DateTime.Now, "Old description"); // PLACEHOLDER FOR TESTING TO BE REMOVED LATER

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