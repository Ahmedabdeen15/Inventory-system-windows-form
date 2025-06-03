using Inventory.data;
using Inventory.veiw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.controller
{
    internal class ReleaseItemController
    {
        InventoryDbContext inventoryDb;
        public List<releasedItem> releasedItems { get; }
        public List<releasedItem> OldreleasedItems { get; }
        public ReleaseItemController(InventoryDbContext inventoryDb)
        {
            this.inventoryDb = inventoryDb;
            releasedItems = new List<releasedItem>();
            OldreleasedItems = new List<releasedItem>();
        }
        public void addReleaseItemPermit(float quntity, WarehouseItem item)
        {
            if (quntity <= 0)
            {
                throw new ArgumentException("Quantity must be greater than zero.");
            }
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Item cannot be null.");
            }
            releasedItem newItem = new releasedItem
            {
                quntity = quntity,
                warehouseItem = item,
            };
            releasedItems.Add(newItem);
        }
        public void updateReleaseItemPermit(float quntity, WarehouseItem item,int releasedItemsId)
        {
            if (quntity <= 0)
            {
                throw new ArgumentException("Quantity must be greater than zero.");
            }
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Item cannot be null.");
            }
            releasedItem releasedItem = releasedItems[releasedItemsId];
            releasedItem.quntity = quntity;
            releasedItem.warehouseItem = item;
        }
        public void insertPermit(DateTime releaseDate,String Pno,Customer customer,Warehouse warehouse)
        {
            if (releaseDate == null)
            {
                throw new ArgumentNullException(nameof(releaseDate), "Supply date cannot be null.");
            }
            if (string.IsNullOrEmpty(Pno))
            {
                throw new ArgumentException("Permit number cannot be null or empty.", nameof(Pno));
            }
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer), "Customer cannot be null.");
            }
            if (warehouse == null)
            {
                throw new ArgumentNullException(nameof(warehouse), "Warehouse cannot be null.");
            }
            foreach (var item in releasedItems)
            {
                if (item.quntity <= 0)
                {
                    throw new ArgumentException("Quantity must be greater than zero for all items.");
                }
                if (item.warehouseItem == null)
                {
                    throw new ArgumentNullException(nameof(item.warehouseItem), "Warehouse item cannot be null.");
                }
                if (item.warehouseItem.quntity < item.quntity)
                {
                    throw new InvalidOperationException("Insufficient quantity in warehouse item.");
                }
                // Update the warehouse item quantity
                item.warehouseItem.quntity -= item.quntity;
            }
            ReleasePermit releasePermit = new ReleasePermit
            {
                ReleaseDate = releaseDate,
                permitNumber = Pno,
                Customer = customer,
                Warehouse = warehouse,
                releasedItems = releasedItems,
            };
            inventoryDb.releasePermits.Add(releasePermit);
            inventoryDb.SaveChanges();
        }
        public void updatePermit(ReleasePermit releasePermit, DateTime releaseDate, String Pno, Customer customer, Warehouse warehouse)
        {
            if (releasePermit == null)
            {
                throw new ArgumentNullException(nameof(releasePermit), "Existing permit cannot be null.");
            }
            if (releaseDate == null)
            {
                throw new ArgumentNullException(nameof(releaseDate), "Release date cannot be null.");
            }
            if (string.IsNullOrEmpty(Pno))
            {
                throw new ArgumentException("Permit number cannot be null or empty.", nameof(Pno));
            }
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer), "Customer cannot be null.");
            }
            if (warehouse == null)
            {
                throw new ArgumentNullException(nameof(warehouse), "Warehouse cannot be null.");
            }
            foreach (var oldItem in OldreleasedItems)
            {
                oldItem.warehouseItem.quntity += oldItem.quntity;
            }
            foreach (var item in releasedItems)
            {
                if (item.quntity <= 0)
                {
                    throw new ArgumentException("Quantity must be greater than zero for all items.");
                }
                if (item.warehouseItem == null)
                {
                    throw new ArgumentNullException(nameof(item.warehouseItem), "Warehouse item cannot be null.");
                }
                if (item.warehouseItem.quntity < item.quntity)
                {
                    throw new InvalidOperationException("Insufficient quantity in warehouse item.");
                }
                // Update the warehouse item quantity
                item.warehouseItem.quntity -= item.quntity;
            }
            // Update permit properties
            releasePermit.ReleaseDate = releaseDate;
            releasePermit.permitNumber = Pno;
            releasePermit.Customer = customer;
            releasePermit.Warehouse = warehouse;
            releasePermit.releasedItems = releasedItems;
            inventoryDb.SaveChanges();
        }
        public List<dynamic> getReleaseItems()
        {
            return releasedItems.Select(item => new
            {
                item.ID,
                ItemName = item.warehouseItem.Item.Name,
                quntity = item.quntity.ToString() + " " + item.warehouseItem.Unit.Name,
                productionDate = item.warehouseItem.productionDate.ToString("yyyy-MM-dd"),
            }).Cast<dynamic>().ToList();
        }
    }
}
