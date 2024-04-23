namespace IntroClass;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Dog pancake = new Dog();

        pancake.name = "pancake";

        //Here we call an instance method - this method needs an object of type Dog to be called.
        pancake.Bark();

        Dog.DefineDog();

    }
}

