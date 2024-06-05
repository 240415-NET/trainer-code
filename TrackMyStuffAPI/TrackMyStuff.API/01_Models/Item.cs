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
    
    //Creating a mapping controller that maps items -> ItemDTOs
    public Item(ItemDTO item, User owner) {
            
            user = owner;
            itemId = Guid.NewGuid();
            category = item.category;
            originalCost = item.originalCost;
            purchaseDate = DateTime.Now;
            description = item.description;
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