using TrackMyStuff.API.Models;
using TrackMyStuff.API.Data;
using TrackMyStuff.API.DTOs;

namespace TrackMyStuff.API.Services;

public class ItemService : IItemService
{
    private readonly IItemStorageEFRepo _itemStorage;

    public ItemService(IItemStorageEFRepo efRepoFromBuilder)
    {
        _itemStorage = efRepoFromBuilder;
    }

    public async Task<ItemDTO> CreateNewItemAsync(ItemDTO newItemFromController)
    {
        await _itemStorage.CreateItemInDBAsync(newItemFromController);

        return newItemFromController;
    }
    
}