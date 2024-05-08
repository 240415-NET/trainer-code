using TrackMyStuff.Models;
using System.Text.Json;

namespace TrackMyStuff.Data;

public class JsonItemStorage : IItemStorageRepo
{
    //If I find myself re-using the same string or object etc, I can go ahead
    //and make it a member of my class. This way I can reuse this same data without
    //having to continuously re-initialize it.
    //The underscore is a common convention to denote variables that are common
    //to the entire class
    public static string filePath = "ItemsFile.json";


    //Changed my methods to be instance methods instead of class methods

    public void StoreItem(Item newItem)
    {

    }
}