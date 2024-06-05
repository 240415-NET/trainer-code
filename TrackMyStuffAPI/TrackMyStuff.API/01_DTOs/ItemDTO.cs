using TrackMyStuff.API.Models;

namespace TrackMyStuff.API.DTOs;

public class ItemDTO
{
    public Guid? userId { get; set; }

    public string category {get; set;}
    public double originalCost {get; set;}
    public DateTime purchaseDate {get; set;}
    public string description {get; set;}

    //Mapping constructor from item to ItemDTO
    public ItemDTO() {}
    public ItemDTO(Item item)
    {
        userId = item.user.userId;
        category = item.category;
        originalCost = item.originalCost;
        purchaseDate = item.purchaseDate;
        description = item.description;
    }

}