using TrackMyStuff.API.DTOs;
using TrackMyStuff.API.Models;

namespace TrackMyStuff.API.Services;

public interface IItemService
{
    public Task<ItemDTO> CreateNewItemAsync(ItemDTO newItem);
    public Task<List<ItemDTO>> GetAllItemsForUserAsync(Guid userId);
}