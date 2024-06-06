using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using TrackMyStuff.API.DTOs;

namespace TrackMyStuff.API.Models;

public class Item
{

    //public Guid userId {get; set;}
    public User user { get; set; } = new();
    //Here we are using data annotations to set the itemId as the primary key
    [Key]
    public Guid itemId {get; set;} 
    public string category {get; set;}
    public double originalCost {get; set;}
    public DateTime purchaseDate {get; set;}
    public string description {get; set;}

    //Constructors 
    public Item() { }
    
    //Creating a mapping constructor to map an item from an ItemDTO and a user object
    public Item(ItemDTO item, User owner) 
    {
        user = owner;
        itemId = Guid.NewGuid();
        category = item.category;
        originalCost = item.originalCost;
        purchaseDate = item.purchaseDate;
        description = item.description;
    }

    //This is my full argument constructor - in our API rendition of trackMyStuff it is vestigial, and doesn't
    //really do anything. 
    public Item(string _category, double _originalCost, 
        DateTime _purchaseDate, string _description) {
            
            itemId = Guid.NewGuid();
            category = _category;
            originalCost = _originalCost;
            purchaseDate = _purchaseDate;
            description = _description;
    }

    public override string ToString()
    {
        return $"Category: {category}\nOriginal Cost: {originalCost}\nPurchase Date: {purchaseDate}\nDescription: {description}";
    }
    public string AbbrToString()
    {
        return String.Format("Description: {0,-25}   Purchase Date: {1,10:d}   Original Cost: {2,-12:C2}",description,purchaseDate,originalCost);
    }

}