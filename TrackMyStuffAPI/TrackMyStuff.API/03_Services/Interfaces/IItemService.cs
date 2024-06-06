using TrackMyStuff.API.DTOs;
using TrackMyStuff.API.Models;

namespace TrackMyStuff.API.Services;

public interface IItemService
{
    public Task<ItemDTO> CreateNewItemAsync(ItemDTO newItemFromController);
    
}