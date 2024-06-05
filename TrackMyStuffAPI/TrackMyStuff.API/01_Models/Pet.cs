namespace TrackMyStuff.API.Models;

public class Pet : Item //Pet inherits from our Item class as well
{
    public string? name {get; set;}

    //Question mark allows this to be a string OR null
    public string? species {get; set;}
    public int? age {get; set;}

    // Constructors
    public Pet() : base() { }


    // An example of calling the base class constructor (ALL POSSIBLE ARGUMENTS in this case)
    
    public override string ToString()
    {
        return $"Category: {category}\nOriginal Cost: {originalCost}\nPurchase Date: {purchaseDate}\nDescription: {description}\nSpecies: {species}\nPet Name: {name}\nPet Age: {age}";
    }
}