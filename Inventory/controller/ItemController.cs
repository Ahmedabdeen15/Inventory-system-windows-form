using Inventory.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.controller
{
    internal class ItemController
    {
        InventoryDbContext inventoryDb;
        public ItemController(InventoryDbContext inventoryDb) 
        {
            this.inventoryDb = inventoryDb;
        }

        public void insertItem(string name, string code)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(code))
            {
                throw new ArgumentException("Invalid item details");
            }
            Item item = new Item
            {
                Name = name,
                ItemCode = code
            };
            inventoryDb.items.Add(item);
            inventoryDb.SaveChanges();
        }
        public void updateItem(int itemId, string name, string code)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(code))
            {
                throw new ArgumentException("Invalid item details");
            }
            Item item = inventoryDb.items.Find(itemId);
            if (item == null)
            {
                throw new KeyNotFoundException("Item not found");
            }
            item.Name = name;
            item.ItemCode = code;
            inventoryDb.SaveChanges();
        }
        public Item getItemById(int itemId)
        {
            Item item = inventoryDb.items.Find(itemId);
            if (item == null)
            {
                throw new KeyNotFoundException("Item not found");
            }
            return item;
        }
        public void insertUnit(int itemId, int unitID)
        {
            Item item = inventoryDb.items.Find(itemId);
            Unit unit = inventoryDb.units.Find(unitID);
            if (item == null || unit == null)
            {
                throw new KeyNotFoundException("Item not found");
            }
            item.units.Add(unit);
            inventoryDb.SaveChanges();
        }
        public void removeUnit(int itemId, int unitID)
        {
            Item item = inventoryDb.items.Find(itemId);
            Unit unit = inventoryDb.units.Find(unitID);
            if (item == null || unit == null)
            {
                throw new KeyNotFoundException("Item not found");
            }
            item.units.Remove(unit);
            inventoryDb.SaveChanges();
        }
        public List<Item> getAllItems()
        {
            return inventoryDb.items.ToList();
        }
        public List<Unit> getItemUnitsById(int itemId)
        {
            Item item = inventoryDb.items.Find(itemId);
            if (item == null)
            {
                throw new KeyNotFoundException("Item not found");
            }
            inventoryDb.Entry(item).Collection(i => i.units).Load();

            return item.units.ToList();
        }
    }
}
