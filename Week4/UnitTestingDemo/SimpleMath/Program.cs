namespace SimpleMath;

public class Program
{
     static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public static bool IsPrime(int x)
    {   
        //Setting up an if-elseif-else block to deal with special cases
        //Since the first if and else if only run one line of code, I can 
        //choose not to include curly braces {}.
        if(x <= 1)
            return false; 
        else if(x == 2)
            return true;
        else
        {
            for(int i = 2; i < x; i++)
            {
                if(x % i == 0)
                    return false;
            } 


            //If we make it here, and the number is not less than 2 or divisible by something that isn't 1
            //we know it is prime. And we return true.
            return true;
        }
        
        
        

    }

}
