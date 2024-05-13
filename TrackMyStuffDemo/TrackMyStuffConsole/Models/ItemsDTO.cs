namespace TrackMyStuff.Models;

public class ItemsDTO
{
    public List<Item>? Items {get; set;}
    public List<Document>? Documents {get; set;}
    public List<Pet>? Pets {get; set;}

    public ItemsDTO()
    {
        this.Items = new List<Item>();
        this.Documents = new List<Document>();
        this.Pets = new List<Pet>();
    }
}