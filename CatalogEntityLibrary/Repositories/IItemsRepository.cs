using System;
using System.Collections.Generic;
using CatalogEntityLibrary.Entities;

namespace CatalogEntityLibrary.Repositories
{
    public interface IItemsRepository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
    }
}