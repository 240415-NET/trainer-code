//For a controller, we always want to bring in Microsoft.AspNetCore.Mvc
//This is where we get things like the ApiController annotation, and the ControllerBase class
using Microsoft.AspNetCore.Mvc;
using TrackMyStuff.API.Models;
using TrackMyStuff.API.DTOs;

namespace TrackMyStuff.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ItemController : ControllerBase
{
    public ItemController() {}
    
}