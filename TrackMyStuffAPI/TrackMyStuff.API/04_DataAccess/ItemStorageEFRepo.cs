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
    
}