using TrackMyStuff.API.Models;
using TrackMyStuff.API.DTOs;
using Microsoft.EntityFrameworkCore;

namespace TrackMyStuff.API.Data;

public class ItemStorageEFRepo : IItemStorageEFRepo
{   
    private readonly TrackMyStuffContext _context;

    public ItemStorageEFRepo (TrackMyStuffContext contextFromBuilder)
    {
        _context = contextFromBuilder;
    }
    
    //In order to create this item in the database, we need to do a little more leg work
    //because every item is associated with a user object.
    public async Task<ItemDTO> CreateItemInDBAsync(ItemDTO newItemFromService)
    {
        //First we need to reach into our DB for the user who's userID corresponds to the one coming in
        //from our DTO
        User? owner = await _context.Users
            .SingleOrDefaultAsync(user => user.userId == newItemFromService.userId);

        //Now we have to create an Item object based on our model, we do not stick the DTO itself into the DB
        Item itemToAdd = new(newItemFromService, owner);

        _context.Add(itemToAdd);

        await _context.SaveChangesAsync();

        return newItemFromService;

    }

    public async Task<List<Item>> GetAllItemsForUserFromDBAsync(Guid userIdFromService)
    {
        //Here we will ask the database for all items associated with the user who's guid matches
        //the userIdFromService, using LINQ methods (and lambdas :c )

        return await _context.Items //So we ask our context for the collection of Item objects in the database
            .Include(item => item.user) //We ask entity framework to also grab the associated User object from the User table
            .Where(item => item.user.userId == userIdFromService) //We then ask for every item who's owner's UserId matches the userIdFromService
            .ToListAsync(); //Finally, we turn those items into a list

    }
    
}