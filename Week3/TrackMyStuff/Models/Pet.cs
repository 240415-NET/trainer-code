namespace TrackMyStuff.Models;

public class Pet : Item //Pet inherits from our Item class as well
{
    public string name {get; set;}

    //Question mark allows this to be a string OR null
    public string? species {get; set;}
    public int? age {get; set;}

    // Constructors
    public Pet() : base() { }

    public Pet(string _name, string _species, int _age) : base() {
        name = _name;
        species = _species;
        age = _age;
        userId = 10;
     }

    // An example of calling the base class constructor (ALL POSSIBLE ARGUMENTS in this case)
    public Pet(int userId, int itemId, string category, double originalCost, 
        DateTime purchaseDate, string description, string _name, string _species, int _age) : 
        base(userId, itemId, category, originalCost,purchaseDate, description)
    {
        name = _name;
        species = _species;
        age = _age;
    }
    
}