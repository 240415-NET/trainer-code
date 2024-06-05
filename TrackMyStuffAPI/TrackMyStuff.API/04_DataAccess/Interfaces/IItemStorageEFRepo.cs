using TrackMyStuff.API.DTOs;
using TrackMyStuff.API.Models;

namespace TrackMyStuff.API.Data;

public interface IItemStorageEFRepo
{
    public Task<ItemDTO> CreateItemInDBAsync(ItemDTO newItem);
    Task<List<Item>> GetAllItemsForUserAsync(Guid userId);
}