//Bringing in classes from our model namespace so we can use it here!
using TrackMyStuff.Models;

namespace TrackMyStuff;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Pet pancake = new Pet("pancake", "dog", 11);

    }
}
