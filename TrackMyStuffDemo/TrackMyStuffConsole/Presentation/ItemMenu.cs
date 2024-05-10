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
                        Console.WriteLine("This will be implemented later, sorry!");
                        break;
                    default:
                        Console.WriteLine("Please key valid option");
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
        //Need to add try-catch!

        string category; 
        double originalCost; 
        DateTime purchaseDate; 
        string description;
        string petName;
        string petSpecies;
        int petAge;

        Console.WriteLine("Please enter the category for your item. (i.e. Furniture, Appliance, etc.)");
        category = Console.ReadLine().Trim();
        Console.WriteLine("What was the original cost for your item? Please enter just the number with no currency sign");
        originalCost = double.Parse(Console.ReadLine().Trim());
        Console.WriteLine("What was the original purchase date of the item?");
        purchaseDate = DateTime.Parse(Console.ReadLine().Trim());
        Console.WriteLine("Enter a description of the item. (i.e. Brown sleeper sofa)");
        description = Console.ReadLine().Trim();
        Console.WriteLine("Enter pet's name. (i.e. Pancake, Pyewacket)");
        petName = Console.ReadLine().Trim();
        Console.WriteLine("Enter pet's species");
        petSpecies = Console.ReadLine().Trim();
        Console.WriteLine("Enter pet's age");
        petAge = Int32.Parse(Console.ReadLine().Trim());

        ItemController.CreatePet(user,category,originalCost,purchaseDate,description,petName,petSpecies,petAge);
    }
    public static void NewDocument(User user)
    {
        //Need to add try-catch!

        string category; 
        double originalCost; 
        DateTime purchaseDate; 
        string description;
        string documentType;
        DateTime expirationDate;

        Console.WriteLine("Please enter the category for your item. (i.e. Furniture, Appliance, etc.)");
        category = Console.ReadLine().Trim();
        Console.WriteLine("What was the original cost for your item? Please enter just the number with no currency sign");
        originalCost = double.Parse(Console.ReadLine().Trim());
        Console.WriteLine("What was the original purchase date of the item?");
        purchaseDate = DateTime.Parse(Console.ReadLine().Trim());
        Console.WriteLine("Enter a description of the item. (i.e. Brown sleeper sofa)");
        description = Console.ReadLine().Trim();
        Console.WriteLine("Enter document type (i.e. Will, Birth Certificate)");
        documentType = Console.ReadLine().Trim();
        Console.WriteLine("Enter document expiration date");
        expirationDate = DateTime.Parse(Console.ReadLine().Trim());                

        ItemController.CreateDocument(user,category,originalCost,purchaseDate,description,documentType,expirationDate);
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

        ItemController.CreateItem(user,category,originalCost,purchaseDate,description);
    }
}