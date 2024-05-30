//For a controller, we always want to bring in Microsoft.AspNetCore.Mvc
//This is where we get things like the ApiController annotation, and the ControllerBase class
using Microsoft.AspNetCore.Mvc;
using TrackMyStuff.API.Models;
using TrackMyStuff.API.DTOs;
using TrackMyStuff.API.Services;

namespace TrackMyStuff.API.Controllers;

//We are going to break our business logic into a Service layer outside of our controllers, to keep them
//relatively small/lightweight. Since the controllers in an ASP.NET application ideally only handle
//receiving and returning HTTP requests. 

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    //I know that im going to need at minimum a place to hold my UserService object, that will be
    //given to me by the builder when the app is dotnet run. We are NOT going to instantiate this object
    //within the controller with the usual Object myObject = new Object() style syntax. We are going to 
    //allow the builder to handle creating and then passing in that UserService object through the controller's Constructor.
    private readonly IUserService _userService;

    //Here is my constructor where we will take in our dependencies (that are automatically passed in by the builder.)
    public UserController(IUserService userServiceFromBuilder) 
    {
        _userService = userServiceFromBuilder;
    }

    //Create a User in our DB
    //Here we are going to create our first controller method. This method needs a few things.
    //It needs an HTTP verb tag, and a method signature that includes the "async" keyword. This 
    //makes the method asynchronous, meaning that we won't lock up program execution across our entire app
    //waiting for someone's potentially slow internet to respond to us. 

    //This is our method to create a new user. We are using a POST request to send a new user 
    //We DONT have to worry about serialization to JSON, or unwrapping that nested Task<ActionResult<User>>
    //object that is eventually returned - ALL of that is handled by ASP.NET
    //This User we call newUser actually comes in from the body of the HTTP request that is sent to this method
    //from the front end. Whether it's us in Swagger, a full fledged website in a browser, a console app, etc. 
    //Our controller unwraps that request, and serializes the JSON representation of our potential new user from the body
    //of the request. We can then work with it like any other object within our code.  
    [HttpPost]
    public async Task<ActionResult<User>> PostNewUser(User newUserSentFromFrontEnd)
    {
        //Inside of our controller, we are going to call a method from our Service layer, from the UserService class.
        //We are going to wrap this in a try-catch so that if anything goes wrong our entire API doesn't immediately go down
        //and we can inform the user that they've messed up.
        try
        {   
            //Inside of our try, we call the CreateNewUserAsync method in our service.
            //The service layer will handle validating that this object meets our criteria
            await _userService.CreateNewUserAsync(newUserSentFromFrontEnd);

            //If it does, we return a 200-OK success message to the user, and echo back the object 
            //that they gave us. 
            return Ok(newUserSentFromFrontEnd);

            //If for some reason the CreateNewUserAsync method fails, we will hit the catch. 
        } 
        catch(Exception e)
        {
            //If something goes wrong, the user sends a bad request, etc - we are going to return
            //a 400 bad request response, with the exception message that it triggered.
            return BadRequest(e.Message);
        }

    }
}