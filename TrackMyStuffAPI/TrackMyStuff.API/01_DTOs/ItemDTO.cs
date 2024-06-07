using TrackMyStuff.API.Models;

namespace TrackMyStuff.API.DTOs;

public class ItemDTO
{
    public Guid userId { get; set; }
    public Guid itemId { get; set; } = Guid.Empty;
    public string category {get; set;}
    public double originalCost {get; set;}
    public DateTime purchaseDate {get; set;}
    public string description {get; set;}

    public ItemDTO() {}

    //Create a mapping constructor to generate ItemDTOs to send back to our front end,
    //based on Item model objects that come back from our database
    public ItemDTO(Item item)
    {
        userId = item.user.userId;
        itemId = item.itemId;
        category = item.category;
        originalCost = item.originalCost;
        purchaseDate = item.purchaseDate;
        description = item.description;
    }

}