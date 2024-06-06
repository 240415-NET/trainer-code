using System.ComponentModel.DataAnnotations;

namespace TrackMyStuff.API.Models;

public class User 
{
    //Fields
    
    //This is an example of leveraging the get;set; shorthand to protect our fields/properties
    //We can shift the burden of the access modifier to the getter or setter, and avoid having
    //to write more code to create a traditional field and property

    //We are using a prebuilt data type from the default System library to generate a truly unique
    //userId
    [Key]
    public Guid userId {get; set;}
    public string userName {get; set;}

    //Users have many items - each one of those items belongs to one user
    //We store these in our models as a list of type items
    //Make sure you actually initialize a list by including "= new();" after the GET-SET
    //Otherwise, when you actually ask the DB for a user object, you will not see it's
    //associated items/pets/documents EVEN IF they are stored in the DB. 

    //IF you choose to use inheritance, we only require a list of the parent class for each hierarchy. 
    //In our case, since pets and documents inherit from items, we will only store a list of items.
    //Entity Framework will see this, and see that pets and documents are child classes of items,
    //and when it generates a database schema for us, pets and documents will in effect inherit the FK
    //relationship with the userId for that pet/document's owner
    //If you see something in the terminal about shadow properties or shadow keys, check to make sure
    //you didn't add a list of child classes or something like that. As that "double applies" the relationship. 
    public List<Item> items {get; set;} = new();

    // public List<Pet> pets {get; set;} = new();
    // public List<Document> documents{get; set;} = new();

    //Constructors

    //Default/No argument constructor
    public User() {}

    //This constructor takes two arguments
    public User(string _userName){
        userId = Guid.NewGuid(); //This creates a random Guid for us, without us having to worry about it
        userName = _userName;
    }
    
    
}