using TrackMyStuff.Controllers;
using TrackMyStuff.Models;

namespace TrackMyStuff.Presentation;

public class NewItemMenu
{
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
        Console.WriteLine("Do you need to create another item?");
        string cont = Console.ReadLine().Trim();
        if (cont == "yes" || cont == "y")
            NewItem(user);
        else
            ItemMenu.ItemFunctionMenu(user);
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
        Console.WriteLine("Do you need to create another item?");
        string cont = Console.ReadLine().Trim();
        if (cont == "yes" || cont == "y")
            NewItem(user);
        else
            ItemMenu.ItemFunctionMenu(user);
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
        Console.WriteLine("Do you need to create another item?");
        string cont = Console.ReadLine().Trim();
        if (cont == "yes" || cont == "y")
            NewItem(user);
        else
            ItemMenu.ItemFunctionMenu(user);
    }
}