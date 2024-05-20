namespace TrackMyStuff.Models;

public class Pet : Item //Pet inherits from our Item class as well
{
    public string name {get; set;}

    //Question mark allows this to be a string OR null
    public string? species {get; set;}
    public int? age {get; set;}

    // Constructors
    public Pet() : base() { }


    // An example of calling the base class constructor (ALL POSSIBLE ARGUMENTS in this case)
    public Pet(Guid userId, string category, double originalCost, 
        DateTime purchaseDate, string description, string _name, string _species, int _age) : 
        base(userId, category, originalCost,purchaseDate, description)
    {
        name = _name;
        species = _species;
        age = _age;
    }
    public override string ToString()
    {
        return $"Category: {category}\nOriginal Cost: {originalCost}\nPurchase Date: {purchaseDate}\nDescription: {description}\nSpecies: {species}\nPet Name: {name}\nPet Age: {age}";
    }

    public bool IsPet()
    {
        return true;
    }    
}