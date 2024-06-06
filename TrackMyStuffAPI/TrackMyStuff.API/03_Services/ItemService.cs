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

    public async Task<List<ItemDTO>> GetAllItemsForUserAsync(Guid userIdFromController)
    {
        List<ItemDTO> foundItems = new();

        //We know we will get something back from the data access layer
        //I've got some assumptions about what it is, but lets say I'm a little lazy
        //We can leverage "var" to make things easier for us 

        var resultList = await _itemStorage.GetAllItemsForUserFromDBAsync(userIdFromController);

        foreach (var item in resultList)
        {
            //For each item model object in our result list, we will call that mapping constructor 
            //that takes an item and uses it to create an ItemDTO for us. Then it adds that new ItemDTO object
            //to the foundItems list we created above.
            foundItems.Add(new ItemDTO(item));
        }

        return foundItems;
    }
    
}