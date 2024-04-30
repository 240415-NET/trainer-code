namespace TrackMyStuff.Models;

public class Item
{
    int userId {get; set;}
    int itemId {get; set;}
    string category {get; set;}
    double originalCost {get; set;}
    DateTime purchaseDate {get; set;}
    string description {get; set;}
    
}