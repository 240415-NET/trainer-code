namespace TrackMyStuff.Models;

public class Document : Item //Document inherits from our Item class
{
    string  documentType {get; set;}
    DateTime expirationDate {get; set;}
    
}