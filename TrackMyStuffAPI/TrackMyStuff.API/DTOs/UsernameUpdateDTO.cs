namespace TrackMyStuff.API.Models;

public class UsernameUpdateDTO
{
    public string? oldUserName { get; set;} = string.Empty;
    public string? newUserName { get; set;} = string.Empty;
}