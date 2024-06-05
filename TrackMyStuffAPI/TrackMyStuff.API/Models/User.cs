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

    //Users have many items/pets/documents - each one of those items belongs to one user
    //We store these in our models as lists of type item/pet/document
    //Make sure you actually initialize a list by including "= new();" after the GET-SET
    //Otherwise, when you actually ask the DB for a user object, you will not see it's
    //associated items/pets/documents EVEN IF they are stored in the DB. 
    public List<Item> items {get; set;} = new();
    //public List<Pet> pets {get; set;} = new();
    //public List<Document> documents{get; set;} = new();

    //Constructors

    //Default/No argument constructor
    public User() {}

    //This constructor takes two arguments
    public User(string _userName){
        userId = Guid.NewGuid(); //This creates a random Guid for us, without us having to worry about it
        userName = _userName;
    }
    
    
}