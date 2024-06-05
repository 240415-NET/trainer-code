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

    public async Task<ItemDTO> CreateNewItemAsync(ItemDTO newItem)
    {
        await _itemStorage.CreateItemInDBAsync(newItem);

        return newItem;
    }

    public async Task<List<ItemDTO>> GetAllItemsForUserAsync(Guid userId)
    {   
        List<ItemDTO> items = new();
        var result = await _itemStorage.GetAllItemsForUserAsync(userId);

        foreach(var item in result)
        {
            items.Add(new ItemDTO(item));
        }

        return items;
    }
}