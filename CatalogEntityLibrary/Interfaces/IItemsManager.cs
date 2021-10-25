using System;
using System.Collections.Generic;
using CatalogEntityLibrary.Entities;

namespace CatalogEntityLibrary.Interfaces
{
    public interface IItemManager
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
        void CreateItem(Item item);
        void UpdateItem(Item item);
        void DeleteItem(Guid id);
    }
}