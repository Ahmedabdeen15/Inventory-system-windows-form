using Inventory.data;
using Microsoft.EntityFrameworkCore;

namespace Inventory.controller
{
    internal class SupplyPermitController
    {
        InventoryDbContext inventoryDb;
        public List<SuppliedItem> suppliedItems { get; }
        public List<SuppliedItem> OldsuppliedItems { get; }

        public SupplyPermitController(InventoryDbContext inventoryDb)
        {
            this.inventoryDb = inventoryDb;
            suppliedItems = new List<SuppliedItem>();
            OldsuppliedItems = new List<SuppliedItem>();
        }

        public void insertPermit(DateTime SupplyDate, string permitNumber, Supplier Supplier, Warehouse Warehouse)
        {
            if (suppliedItems.Count < 0)
            {
                throw new Exception("Permit has no Items");
            }
            if (string.IsNullOrEmpty(permitNumber) || Supplier == null || Warehouse == null)
            {
                throw new Exception("failed to insert permit....wrong inputs");
            }
            foreach (var Item in suppliedItems)
            {
                var query = from item in Warehouse.warehouseItems
                            where item.Item.ItemId == Item.Item.ItemId
                            && item.Unit == Item.Unit
                            && item.ExpirationDate == Item.ExpirationDate
                            && item.productionDate == Item.ProudctionDate
                            select item;
                foreach (var warehouseItem in query)
                {
                    warehouseItem.quntity += Item.quntity;
                    Item.WarehouseItem = warehouseItem;
                }
                if (Item.WarehouseItem == null)
                {
                    WarehouseItem newWarehouseItem = new WarehouseItem()
                    {
                        Item = Item.Item,
                        quntity = Item.quntity,
                        productionDate = Item.ProudctionDate,
                        ExpirationDate = Item.ExpirationDate,
                        Unit = Item.Unit,
                        Warehouse = Warehouse
                    };
                    Item.WarehouseItem = newWarehouseItem;
                    Warehouse.warehouseItems.Add(newWarehouseItem);
                }
            }
            supplyPermit newPermit = new supplyPermit()
            {
                SupplyDate = SupplyDate,
                permitNumber = permitNumber,
                Supplier = Supplier,
                Warehouse = Warehouse,
                suppliedItems = suppliedItems
            };
            inventoryDb.supplyPermits.Add(newPermit);
            inventoryDb.SaveChanges();
        }
        private void transferItem(Warehouse oldWarehouse, Warehouse newWarehouse, supplyPermit supplyPermit)
        {
            //remove quntity from old warehouse
            foreach (var Item in supplyPermit.suppliedItems)
            {
                var query = from item in oldWarehouse.warehouseItems
                            where item.Item.ItemId == Item.Item.ItemId
                            && item.Unit == Item.Unit
                            && item.ExpirationDate == Item.ExpirationDate
                            && item.productionDate == Item.ProudctionDate
                            select item;
                foreach (var warehouseItem in query)
                {
                    warehouseItem.quntity -= Item.quntity;
                    if (warehouseItem.quntity <= 0)
                    {
                        oldWarehouse.warehouseItems.Remove(warehouseItem);
                        inventoryDb.warehouseItems.Remove(warehouseItem);
                        supplyPermit.suppliedItems.Remove(Item);
                    }
                }
            }
            //add quntity to new warehouse
            foreach (var Item in supplyPermit.suppliedItems)
            {
                var query = from item in newWarehouse.warehouseItems
                            where item.Item.ItemId == Item.Item.ItemId
                            && item.Unit == Item.Unit
                            && item.ExpirationDate == Item.ExpirationDate
                            && item.productionDate == Item.ProudctionDate
                            select item;
                foreach (var warehouseItem in query)
                {
                    warehouseItem.quntity += Item.quntity;
                    Item.WarehouseItem = warehouseItem;
                }
                if (Item.WarehouseItem == null)
                {
                    WarehouseItem newWarehouseItem = new WarehouseItem()
                    {
                        Item = Item.Item,
                        quntity = Item.quntity,
                        productionDate = Item.ProudctionDate,
                        ExpirationDate = Item.ExpirationDate,
                        Unit = Item.Unit,
                        Warehouse = newWarehouse
                    };
                    Item.WarehouseItem = newWarehouseItem;
                    newWarehouse.warehouseItems.Add(newWarehouseItem);
                }
            }
        }
        public void updateSupplyItemPermit(supplyPermit supplyPermit, DateTime SupplyDate,
            string permitNumber, Supplier Supplier, Warehouse Warehouse)
        {
            if (suppliedItems.Count == 0)
            {
                throw new Exception("Permit has no Items");
            }
            if (string.IsNullOrEmpty(permitNumber) || Supplier == null || Warehouse == null)
            {
                throw new Exception("failed to update permit....wrong inputs");
            }
            if (supplyPermit.Warehouse.WarehouseID != Warehouse.WarehouseID)
            {
                transferItem(supplyPermit.Warehouse, Warehouse, supplyPermit);
            }
            else
            {

                foreach (var newItem in suppliedItems)
                {
                    var queryResult = (from item in Warehouse.warehouseItems
                                       where newItem.WarehouseItem != null
                                       && item.Id == newItem.WarehouseItem.Id
                                        && item.Item.ItemId == newItem.Item.ItemId
                                        && item.Unit == newItem.Unit
                                        && item.ExpirationDate == newItem.ExpirationDate
                                        && item.productionDate == newItem.ProudctionDate
                                       select item).FirstOrDefault();
                    if (queryResult != null)
                    {
                        float diffrance = newItem.quntity - queryResult.quntity;
                        if (diffrance != 0)
                        {
                            queryResult.quntity += diffrance;
                        }

                    }
                    else
                    {
                        var updateItem = (from item in Warehouse.warehouseItems
                                          where newItem.WarehouseItem != null
                                          && item.Id == newItem.WarehouseItem.Id
                                          select item).FirstOrDefault();
                        var oldValue = (from item in supplyPermit.suppliedItems
                                        where item.WarehouseItem != null
                                        && newItem.WarehouseItem != null
                                        && item.WarehouseItem.Id == newItem.WarehouseItem.Id
                                        select item).FirstOrDefault();
                        if (updateItem != null && oldValue != null)
                        {
                            float diffrance = updateItem.quntity - oldValue.quntity;
                            if (diffrance > 0)
                            {
                                updateItem.quntity += diffrance;
                            }
                            else if (diffrance == 0)
                            {
                                WarehouseItem newWarehouseItem = new WarehouseItem()
                                {
                                    Item = newItem.Item,
                                    quntity = newItem.quntity,
                                    productionDate = newItem.ProudctionDate,
                                    ExpirationDate = newItem.ExpirationDate,
                                    Unit = newItem.Unit,
                                    Warehouse = Warehouse
                                };
                                newItem.WarehouseItem = newWarehouseItem;
                                Warehouse.warehouseItems.Add(newWarehouseItem);
                                inventoryDb.warehouseItems.Remove(updateItem);
                            }
                        }
                        else
                        {
                            //if the item is not in the warehouse, we need to add it
                            WarehouseItem newWarehouseItem = new WarehouseItem()
                            {
                                Item = newItem.Item,
                                quntity = newItem.quntity,
                                productionDate = newItem.ProudctionDate,
                                ExpirationDate = newItem.ExpirationDate,
                                Unit = newItem.Unit,
                                Warehouse = Warehouse
                            };
                            newItem.WarehouseItem = newWarehouseItem;
                            Warehouse.warehouseItems.Add(newWarehouseItem);

                        }
                    }
                }
            }
            supplyPermit.SupplyDate = SupplyDate;
            supplyPermit.permitNumber = permitNumber;
            supplyPermit.Supplier = Supplier;
            supplyPermit.Warehouse = Warehouse;
            supplyPermit.suppliedItems = suppliedItems;
            inventoryDb.SaveChanges();
        }
        public void addSupplyItemPermit(float quntity, DateTime ProudctionDate,
            int ExpirationDays, Item Item, Unit Unit)
        {
            if (quntity < 0 || ExpirationDays < 0 || Item == null || Unit == null)
            {
                throw new ArgumentException("failed to insert item....wrong inputs");
            }
            SuppliedItem suppliedItem = new SuppliedItem()
            {
                quntity = quntity,
                ProudctionDate = ProudctionDate,
                ExpirationDays = ExpirationDays,
                Item = Item,
                Unit = Unit
            };
            suppliedItems.Add(suppliedItem);
        }
        public void addSupplyItemPermit(WarehouseItem item ,float quntity)
        {
           
            SuppliedItem suppliedItem = new SuppliedItem()
            {
                quntity = quntity,
                ProudctionDate = item.productionDate,
                ExpirationDays = (item.productionDate - item.ExpirationDate).Days,
                Item = item.Item,
                Unit = item.Unit
            };
            suppliedItems.Add(suppliedItem);
        }
        public void updateSupplyItemPermit(int id, float quntity, DateTime ProudctionDate,
            int ExpirationDays, Item Item, Unit Unit)
        {
            if (id < 0 || id >= suppliedItems.Count)
            {
                throw new ArgumentException("failed to update item....wrong id");
            }
            if (quntity < 0 || ExpirationDays < 0 || Item == null || Unit == null)
            {
                throw new ArgumentException("failed to update item....wrong inputs");
            }
            SuppliedItem suppliedItem = suppliedItems[id];
            suppliedItem.ProudctionDate = ProudctionDate;
            suppliedItem.ExpirationDays = ExpirationDays;
            suppliedItem.Item = Item;
            suppliedItem.Unit = Unit;
            suppliedItem.quntity = quntity;
        }
        public List<dynamic> getItems()
        {
            var items = (from item in suppliedItems
                         select new
                         {
                             item.Item.Name,
                             quntity = item.quntity.ToString() + " " + item.Unit.Name,
                             item.ProudctionDate,
                             item.ExpirationDate,
                             item.ExpirationDays,
                         }).Cast<dynamic>().ToList();
            return items;
        }
        public List<dynamic> getItems(int selectedPermitId)
        {
            var permit = inventoryDb.supplyPermits
                        .Include(p => p.suppliedItems)
                            .ThenInclude(si => si.Item)
                        .Include(p => p.suppliedItems)
                            .ThenInclude(si => si.Unit)
                        .FirstOrDefault(p => p.PermitId == selectedPermitId);

            var items = (from item in suppliedItems
                         select new
                         {
                             item.Item.Name,
                             quntity = item.quntity.ToString() + " " + item.Unit.Name,
                             item.ProudctionDate,
                             item.ExpirationDate,
                             item.ExpirationDays,
                         }).Cast<dynamic>().ToList();
            return items;
        }
        public void removeSupplyUpdate(int index, Warehouse warehouse) {
            if(suppliedItems[index].WarehouseItem != null)
            {
                float differance = suppliedItems[index].WarehouseItem.quntity - OldsuppliedItems[index].quntity ;
                if (differance > 0)
                {
                    suppliedItems[index].WarehouseItem.quntity = differance;
                }
                else if (differance == 0) {
                    warehouse.warehouseItems.Remove(suppliedItems[index].WarehouseItem);
                    suppliedItems.RemoveAt(index);
                }
            }
            else
            {
                suppliedItems.RemoveAt(index);
            }
        }
    }
}
