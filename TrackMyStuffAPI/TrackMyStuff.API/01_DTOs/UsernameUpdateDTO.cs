namespace TrackMyStuff.API.Models;

//This is our first DTO. It will not be added to the TrackMyStuffContext
//It will not be reflected as a table in our DB. We will use it 
//to make our update process simpler, and to make our HTTP Requests coming in 
//from the front end simpler to write. 
public class UsernameUpdateDTO
{
    public string? oldUserName { get; set; } = string.Empty;
    public string? newUserName { get; set;} = string.Empty;
}