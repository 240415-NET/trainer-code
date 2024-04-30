namespace TrackMyStuff.Models;

public class Document : Item //Document inherits from our Item class
{
    public string  documentType {get; set;}
    public DateTime expirationDate {get; set;}

    
    
}