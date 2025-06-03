using Inventory.data;
using Microsoft.EntityFrameworkCore;

namespace Inventory.controller
{
    class TransferController
    {
        InventoryDbContext InventoryDbContext;
        public List<transferItem> transferItems { get; } = new List<transferItem>();
        SupplyPermitController supplyPermitController;
        ReleaseItemController releaseItemController;
        public TransferController(InventoryDbContext inventoryDbContext)
        {
            // Initialize the controller with the provided InventoryDbContext
            this.InventoryDbContext = inventoryDbContext;
        }
        public List<dynamic> getTreansferItems()
        {
            return (from i in transferItems
                    select new
                    {
                        i.warehouseItem.Item.Name,
                        i.quntity,
                    }).Cast<dynamic>().ToList();
        }
        public List<dynamic> getTreansferItemsqqqq()
        {
            return InventoryDbContext.transferItems
                .Include(t => t.warehouseItem)
                .ThenInclude(t => t.Item)
                .Include(t => t.FromWarehouse)
                .Include(t => t.ToWarehouse)
                .Include(t => t.supplier)
                .Select(t => new
                {
                    t.ID,
                    WarehouseItem = t.warehouseItem.Item.Name,
                    t.quntity,
                    //t.warehouseItem.productionDate,
                    //t.warehouseItem.ExpirationDate,
                    //FromWarehouse = t.FromWarehouse.Name,
                    //ToWarehouse = t.ToWarehouse.Name,
                    //Supplier = t.supplier.name,
                }).Cast<dynamic>().ToList();
        }
        public void addTransferedItem(WarehouseItem item, float quntity)
        {
            if (quntity <= 0)
            {
                throw new ArgumentException("Quantity must be greater than zero.");
            }
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Item cannot be null.");
            }
            transferItem newItem = new transferItem
            {
                quntity = quntity,
                warehouseItem = item,
            };
            transferItems.Add(newItem);
        }

        public void saveTransferedItems(Warehouse fromWarehouse, Warehouse toWarehouse, Supplier supplier)
        {
            if (fromWarehouse == null || toWarehouse == null || supplier == null)
            {
                throw new ArgumentNullException("Warehouses and supplier cannot be null.");
            }
            supplyPermitController = new SupplyPermitController(InventoryDbContext);
            releaseItemController = new ReleaseItemController(InventoryDbContext);
            foreach (var item in transferItems)
            {
                supplyPermitController.addSupplyItemPermit(item.warehouseItem, item.quntity);
            }
            supplyPermitController.insertPermit(DateTime.Now, "Transfer Permit", supplier, toWarehouse);
            foreach (var item in transferItems)
            {
                releaseItemController.addReleaseItemPermit(item.quntity, item.warehouseItem);
            }
            Customer customer = new Customer
            {
                name = supplier.name,
                fax = supplier.fax,
                phone = supplier.phone,
                mobile = supplier.mobile,
                email = supplier.email,
                website = supplier.website
            };
            releaseItemController.insertPermit(DateTime.Now, "Transfer Permit", customer, fromWarehouse);

            foreach (var item in transferItems)
            {
                item.FromWarehouse = fromWarehouse;
                item.ToWarehouse = toWarehouse;
                item.supplier = supplier;
                InventoryDbContext.transferItems.Add(item);
            }

            InventoryDbContext.SaveChanges();
        }
    }
}
