using TrackMyStuff.API.Models;

namespace TrackMyStuff.API.DTOs;

public class ItemDTO
{
    public Guid userId { get; set; }
    public string category {get; set;}
    public double originalCost {get; set;}
    public DateTime purchaseDate {get; set;}
    public string description {get; set;}

    public ItemDTO() {}

}