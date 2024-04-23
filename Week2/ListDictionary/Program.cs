namespace ListDictionary;
using System.Collections.Generic;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //Dynamically sized collection of objects of a single type. Can hold duplicate values.
        List<string> cityList = new List<string>();

        cityList.Add("Miami");
        cityList.Add("Tampa");
        cityList.Add("Sarasota");
        cityList.Add("Chicago");
        cityList.Add("Clearwater");

        //
        foreach(string city in cityList)
        {
            Console.WriteLine(city);
        }


        //Dictionary - This is a dynamically sized collection that holds key-value pairs
        //Keys must be unique 
        //Keys can also be of any type - as long as it fits the type of the Dictionary
        //This is an example of a shortend object initializer, this and the above initializer for the List
        //are equivalent. 
        //Dictionary<string, List<string>> petDictionary = new Dictionary<string, List<string>>();
        // Dictionary<string, List<string>> petDictionary = new();

        // //delcaring a list we can then pass in
        // List<string> jonPets = new List<string>(){"Ellie", "Pancake"};

        // //This is an example of nesting collections. You can nest a dictionary within a dictionary, if needed.
        // //Instead of creating my lists somewhere else, I can create them while adding to my Dictionary
        // //But as long as it receives a value of type List<string> 
        // petDictionary.Add("Jonathan", jonPets);
        // petDictionary.Add("Ross",new List<string>(){"Brodie"});
        // petDictionary.Add("Mike",new List<string>(){"Carl"});
        // petDictionary.Add("Marcus", new List<string>(){"Ziggy", "Luna", "Amelia", "Pyewacket", "Love Muffin"});

        Dictionary<string, string> simplePets = new Dictionary<string, string>();
        simplePets.Add("Jonathan", "Ellie");
        simplePets.Add("Ross", "Brodie");
        simplePets.Add("Mike", "Carl");
        simplePets.Add("Marcus", "LoveMuffin");

        //This is an example of implicit typing using "var" in C#
        //The compiler will attempt to infer the type of the object based on what you shove into it
        //Just because we can do something, doesn't mean we should! It can save us time in cases like 
        //this, but in general we want to use typed variables in our code.
        foreach (var household in simplePets)
        {   
            Console.WriteLine(household.GetType());
            Console.WriteLine(household.Key + " owns " + household.Value);
        }

        //These two foreach loops are functionally equivalent, one is just explicitly typed. 
        foreach (KeyValuePair<string, string> household in simplePets)
        {   
            Console.WriteLine(household.Key + " owns " + household.Value);
        }
        
    }
}