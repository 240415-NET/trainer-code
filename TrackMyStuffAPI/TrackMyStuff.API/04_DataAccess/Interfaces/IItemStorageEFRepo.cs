using TrackMyStuff.API.DTOs;
using TrackMyStuff.API.Models;

namespace TrackMyStuff.API.Data;

public interface IItemStorageEFRepo
{
    public Task<ItemDTO> CreateItemInDBAsync(ItemDTO newItemFromService);
}