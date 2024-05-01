namespace TrackMyStuff.Models;

public class Item
{
    public int userId {get; set;}
    public int itemId {get; private set;}
    public string category {get; set;}
    public double originalCost {get; set;}
    public DateTime purchaseDate {get; set;}
    public string description {get; set;}

    //Constructors 
    public Item() { }
    
    public Item(int _userId, int _itemId, string _category, double _originalCost, 
        DateTime _purchaseDate, string _description) {
            userId = _userId;
            itemId = _itemId;
            category = _category;
            originalCost = _originalCost;
            purchaseDate = _purchaseDate;
            description = _description;
    }


}