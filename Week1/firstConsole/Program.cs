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
    
        //As a language, C# doesn't care about indentations, just line endings and 
        //logical blocks of code.
        Console.WriteLine("Hello, World!"); 
        Console.WriteLine("Some other thing");

        //This is how we declare a variable 
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
        //numeric type conversion - explicit and implicit
        double someDecimal = 4.99999999;

        //We need to explicitly convert between a Double -> an Int
        //because we WILL lose data when we do so
        int someInteger = (int) someDecimal;

        //We can implicitly convert between Integer -> Double
        //because we will not lose data
        int someOtherInteger = 5;
        double someOtherDouble = someOtherInteger;


        //char - single character
        //Double quotes in C# are used for string values, single quotes are for char values
        char userSelection = 'a';

        Console.WriteLine(age); 

        //Logical operators - return true or false booleans
        // (condition 1) || (condition 2) - logical OR operator, if either condition is true the result is true
        // (condition 1) && (condition 2) - logical AND operator, if both conditions are true, the result is true
        // (!condition 1) - the logical NOT operator, if this condition is true, we return false

        // comparison operators - return true or false booleans
        // == - equal to, returns true if both values are equal
        // != - NOT equal to, returns true if values aren't equal
        // > - greater than
        // < - less than
        // >= - greater than or equal to
        // <= - less than or equal to

        //control flow basics
        //conditional statements
        
        //User input via console, using Console.Readline()
        Console.WriteLine("Please enter a number for the IF-ELSE:");
        
        //Returning user input by explicitly storing values in variables
        //string userInput = Console.ReadLine();
        //int newInt = Convert.ToInt32(userInput);
        
        //returning user inputted integer value, using nested method calls
        int newInt = Convert.ToInt32(Console.ReadLine());

        //if-else if-else
        if (newInt == 4)
        {
            Console.WriteLine("newInt equals 4!");
        }
        else if ( newInt >= 8)
        {
            Console.WriteLine("newInt is greater than 7!");
        }
        else if (newInt < 0)
        {
            Console.WriteLine("newInt is negative!");
        }
        else
        {
            Console.WriteLine("newInt is.... a number");
        }

        //We can address the above logic in a cleaner manner using a SWITCH statement
        Console.WriteLine("Please enter a number for the SWITCH:"); 
        int switchInt = Convert.ToInt32(Console.ReadLine());

        switch (switchInt)
        {
            case 1 or 2: //If switchInt is equal to 1, run the code below until we hit the break statement
                Console.WriteLine("switchInt is equal to 1!");
                break;
            case >= 8 and <= 12: 
                Console.WriteLine("switchInt is greater than 7!");
                break;
            case < 0:
                Console.WriteLine("switchInt is negative!");
                break;
            default:
                Console.WriteLine("switchInt is.... a number.");
                break;
        }

        //If statements can be used to evaluate against two separate variables
        if (newInt > 3 && switchInt > 3)
        {
            Console.WriteLine("Both variables are");
            //We can even nest conditions like math using parenthesis... this can quickly get complicated!
        }else if (newInt < -2 && !(newInt == 5 || switchInt == 2))
        {
            Console.WriteLine("This one is more complex...");
        }

        newInt = 5;

        //loops 
        //this is our FOR loop
        for (int i = 0; i < newInt; i++)
        {
            //This code will run, as long as the above condition is met
            //Here, we use string concatenation to add in the value of i + 1 to our string, for formatting purposes
            Console.WriteLine(i+1 + ". This is coming from my For loop");
        }

        newInt = 10;
        //bool flag = true;
        //while loop - checks a condition THEN runs the code
        while (newInt > 0)
        {
            Console.WriteLine(newInt);
            //flag = false;
            //Remember to include some way for the loop to end. We do not want to create infinite loops. 
            //newInt = newInt - 1;
            newInt--;
            //newInt -= 2; 
        }

        //do-while loop - Runs the code THEN checks the condition
        //it will always run ATLEAST ONCE
        newInt = 0;
        do
        {
            Console.WriteLine("This is from inside my do-while loop!");
        }
        while(newInt > 0);

    }//We begin a logical block with { and end it with a }

    static void bark() //This bark method
    {
        int age = 5;
        Console.WriteLine("Bark!"); 
    }

}
