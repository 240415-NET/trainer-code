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
    public async Task<ItemDTO> CreateItemInDBAsync(ItemDTO newItem)
    {
        User owner = await _context.Users.SingleOrDefaultAsync(user => user.userId == newItem.userId);
        Item itemModelToAdd = new Item(newItem, owner);

        _context.Items.Add(itemModelToAdd);

        await _context.SaveChangesAsync();

        return newItem;
    }

    public async Task<List<Item>> GetAllItemsForUserAsync(Guid userId)
    {
        return await _context.Items.Include(item => item.user).Where(item => item.user.userId == userId).ToListAsync();
    }
}