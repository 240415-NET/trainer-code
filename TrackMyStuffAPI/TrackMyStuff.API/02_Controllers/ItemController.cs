//For a controller, we always want to bring in Microsoft.AspNetCore.Mvc
//This is where we get things like the ApiController annotation, and the ControllerBase class
using Microsoft.AspNetCore.Mvc;
using TrackMyStuff.API.Models;
using TrackMyStuff.API.Services;
using TrackMyStuff.API.DTOs;

namespace TrackMyStuff.API.Controllers;

[ApiController]
public class ItemController : ControllerBase
{
    private readonly IItemService _itemService;

    public ItemController(IItemService itemServiceFromBuilder) 
    {
        _itemService = itemServiceFromBuilder;
    }
    
    [HttpPost("/Item")]
    public async Task<ActionResult<ItemDTO>> PostNewItem(ItemDTO newItem)
    {
        //Inside of our controller, we are going to call a method from our Service layer, from the UserService class.
        //We are going to wrap this in a try-catch so that if anything goes wrong our entire API doesn't immediately go down
        //and we can inform the user that they've messed up.
        try
        {   
            
            //Inside of our try, we call the CreateNewUserAsync method in our service.
            //The service layer will handle validating that this object meets our criteria
            await _itemService.CreateNewItemAsync(newItem);

            //If it does, we return a 200-OK success message to the user, and echo back the object 
            //that they gave us. 
            return Ok(newItem);

        } 
        catch(Exception e)
        {
            //If something goes wrong, the user sends a bad request, etc - we are going to return
            //a 400 bad request response, with the exception message that it triggered.
            return BadRequest(e.Message);
        }

    }

    [HttpGet("/Items")]
    public async Task<ActionResult<List<ItemDTO>>> GetAllItems(Guid userId)
    {
        try
        {   
            List<ItemDTO> itemsFound = await _itemService.GetAllItemsForUserAsync(userId);
            return Ok(itemsFound);

        } 
        catch(Exception e)
        {
            //If something goes wrong, the user sends a bad request, etc - we are going to return
            //a 400 bad request response, with the exception message that it triggered.
            return BadRequest(e.Message);
        }
    }
}

