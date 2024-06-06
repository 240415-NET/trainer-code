namespace TrackMyStuff.API.Models;

public class Document : Item //Document inherits from our Item class
{
    public string documentType {get; set;}
    public DateTime expirationDate {get; set;}

    //Adding a no-arg constructor for EF model creation during database operations
    public Document() {}

    public Document(string category, double originalCost, 
        DateTime purchaseDate, string description, string documentType, DateTime expirationDate) : 
        base(category, originalCost,purchaseDate, description)
    {
        this.documentType = documentType;
        this.expirationDate = expirationDate;
    }
    public override string ToString()
    {
        return $"Category: {category}\nOriginal Cost: {originalCost}\nPurchase Date: {purchaseDate}\nDescription: {description}\nDocument Type: {documentType}\nExpiration Date: {expirationDate}";
    }
}