//I can use the "//" to denote that everything after them on a given line, is a comment

/*
Block comments! Every line between these, is now treated 
as a comment, with no forward slashes needed
on new lines. 
*/

//We want to use comments liberally, to document our code. 

//We can include libraries with pre-written code from outside of our application,
//with the USING statement
using System;

//We can think of a namespace as a filing cabinet, to store and organize our code into.
namespace firstConsole;

//This is a class.
//Classes contain members, which are called fields and methods. 
//fields are variables ex. int age = 10;
//methods are functions, they are blocks of code we can re-use to do some function, throughout our code.
class Program
{
    //This method, Main, is the entry point to our program. 
    static void Main(string[] args)
    {//These curly braces denote logical blocks of code
    
        //As a language, C# doesnt care about indentations, just line endings and 
        //logical blocks of code.
        Console.WriteLine("Hello, World!"); 
        Console.WriteLine("Some other thing");

        //This is how we decalre a variable 
        //We have the type, then the variable's name, and finally a value.
        //(type) (name) = (value);
        int age = 5;

        //The '=' sign, is the assignment operator. It's used to assign a value
        //to a variable.

        //We've already played with integers and strings, there are many pre-built data types
        //in C#, here are the most common.

        //int - holds integer values (whole numbers only)
        //double, float - hold decimal numbers 
        //char - holds a single character
        //string - holds a series of characters (In C#, a string is treated as an array of chars)
        //boolean - holds either "true" or "false" 

        //Strings
        //I can declare a variable, and then assign it a value later.
        //Right now, this string contains a null. 
        //If I were to assign it ="" , this would be an empty string. 
        string name;

        //Assigning that value to my above string. We don't have to declare and assign at the same time.
        name = "Ron";

        //booleans - just true/false
        bool condition = true;
        condition = false;

        //decimal types - double and float
        double weight = 201.4;

        //char - single character
        //Double quotes in C# are used for string values, single quotes are for char values
        char userSelection = 'a';

        Console.WriteLine(age); 



    }//We begin a logical block with { and end it with a }

    static void bark() //This bark method
    {
        int age = 5;
        Console.WriteLine("Bark!"); 
    }

}
