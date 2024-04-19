namespace MethodExceptionDemo;

class AddingProgram
{
    static void Main(string[] args)
    {   
        //We call a method by referencing it's name.
        //Arguments for that method are separated by a comma.
        int firstNum = 4;
        int secondNum = 10;

        //int sum = AddingProgram.AddTwoNumbers(firstNum, secondNum);

        //This is an example of string interpolation using $
        Console.WriteLine($"The sum of {firstNum} and {secondNum} is: {AddTwoNumbers(firstNum, secondNum)}");


    }//end Main scope

    //(access modifier) (return type) (arguments) - arguments are given a type, and a name like a field
    static int AddTwoNumbers(int num1, int num2)
    {
        //I can access arguments passed into my method within the method's block of code
        int sum = num1 + num2;

        //return allows us to return something (value, object, etc) to where this method was called
        return sum;
    
    }//end AddTwoNumbers scope

}
