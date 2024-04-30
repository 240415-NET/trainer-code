namespace TrackMyStuff.Models;

public class User
{
    //Fields
    
    //This is an example of leveraging the get;set; shorthand to protect our fields/properties
    //We can shift the burden of the access modifier to the getter or setter, and avoid having
    //to write more code to create a traditional field and property
    public int userId {get; private set;}
    public string userName {get; private set;}

    //Constructors

    //Default/No argument constructor
    public User() {}

    //This constructor takes two arguments
    public User(int _userId, string _userName){
        userId = _userId;
        userName = _userName;
    }
    
    
}
