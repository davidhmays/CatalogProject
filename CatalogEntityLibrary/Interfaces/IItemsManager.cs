using System;
using System.Collections.Generic;
using CatalogEntityLibrary.Entities;

namespace CatalogEntityLibrary.Interfaces
{
    public interface IItemsManager
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
    }
}