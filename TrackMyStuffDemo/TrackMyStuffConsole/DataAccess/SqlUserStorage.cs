using TrackMyStuff.Models;

namespace TrackMyStuff.Data;

public class SqlUserStorage
{
    //Using a verbatim string literal to ignore all issues related to the slashes for windows file paths
    //And using an absolute file path, starting from my C drive to avoid any relative file path issues
    //If I move my entire project directory, this file path will still work because it's an exact address to my
    //connection string
    public static string connectionString = File.ReadAllText(@"C:\Users\JonathanDeLaCruz\Documents\Revature\connstring.txt");

    
}