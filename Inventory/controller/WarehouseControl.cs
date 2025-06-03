using Inventory.data;
using Microsoft.EntityFrameworkCore;

namespace Inventory.controller
{
    internal class WarehouseControl
    {
        InventoryDbContext inventoryDb;
        EmployeeControl employeeControl;

        public WarehouseControl(InventoryDbContext inventoryDb)
        {
            this.inventoryDb = inventoryDb;
            employeeControl = new EmployeeControl(inventoryDb);
        }
        public void insertWarehouse(string name, string location, Employee employee)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(location))
            {
                throw new ArgumentException("Name and location cannot be null or empty");
            }
            Warehouse warehouse = new Warehouse
            {
                Name = name,
                address = location,
                manger = employee //manager
            };
            inventoryDb.warehouses.Add(warehouse);
            inventoryDb.SaveChanges();
        }
        public void updateWarehouse(int warehouseId, string name, string location, Employee employee)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(location))
            {
                throw new ArgumentException("Name and location cannot be null or empty");
            }
            Warehouse warehouse = inventoryDb.warehouses.Find(warehouseId);
            if (warehouse == null)
            {
                throw new KeyNotFoundException("Warehouse not found");
            }
            warehouse.Name = name;
            warehouse.address = location;
            warehouse.manger = employee;
            inventoryDb.SaveChanges();
        }

        public Warehouse getWarehouseById(int warehouseId)
        {
            Warehouse warehouse = inventoryDb.warehouses.Find(warehouseId);
            if (warehouse == null)
            {
                throw new KeyNotFoundException("Warehouse not found");
            }
            return warehouse;
        }
        public List<Warehouse> getAllWarehouses()
        {
            return inventoryDb.warehouses.ToList();
        }
        public List<dynamic> getAllWarehousesItem()
        {
            var query = (from w in inventoryDb.warehouses
                         from i in w.warehouseItems
                         where i.quntity > 0
                         select new
                         {
                             warehouse_name = w.Name,
                             ItemName = i.Item.Name,
                             quntity = i.quntity.ToString() + " " + i.Unit.Name,  
                             productionDate = i.productionDate.ToString("yyyy-MM-dd"),  
                             ExpirationDate = i.ExpirationDate.ToString("yyyy-MM-dd")   
                         }).Cast<dynamic>().ToList();
            return query;
        }
        public List<dynamic> getAllWarehousesItem(
                            List<int> warehouseIds = null,     
                            List<int> itemIds = null,          
                            DateTime? fromDate = null,         
                            DateTime? toDate = null) 
        {
            var query = from w in inventoryDb.warehouses
                        from i in w.warehouseItems
                        where
                            (warehouseIds == null || warehouseIds.Count == 0 || warehouseIds.Contains(w.WarehouseID)) &&
                            (itemIds == null || itemIds.Count == 0 || itemIds.Contains(i.Item.ItemId)) &&
                            (!fromDate.HasValue || i.productionDate >= fromDate.Value) &&
                            (!toDate.HasValue || i.productionDate <= toDate.Value) &&
                            ( i.quntity > 0)
                        select new
                        {
                            warehouse_name = w.Name,
                            ItemName = i.Item.Name,
                            quntity = i.quntity.ToString() + " " + i.Unit.Name,
                            productionDate = i.productionDate.ToString("yyyy-MM-dd"),
                            ExpirationDate = i.ExpirationDate.ToString("yyyy-MM-dd")
                        };

            return query.Cast<dynamic>().ToList();
        }
        public List<dynamic> getAllWarehousesItem(
                        List<int> warehouseIds = null,     
                        int? itemId = null,                
                        DateTime? fromDate = null,         
                        DateTime? toDate = null          
                        )
        {
            var query = from w in inventoryDb.warehouses
                        from i in w.warehouseItems
                        where

                            (warehouseIds == null || warehouseIds.Count == 0 || warehouseIds.Contains(w.WarehouseID)) &&
                            (!itemId.HasValue || i.Item.ItemId == itemId.Value) &&
                            (!fromDate.HasValue || i.productionDate >= fromDate.Value) &&
                            (!toDate.HasValue || i.productionDate <= toDate.Value) &&
                            (i.quntity > 0)
                        select new
                        {
                            warehouse_name = w.Name,
                            ItemName = i.Item.Name,
                            quntity = i.quntity.ToString() + " " + i.Unit.Name,
                            productionDate = i.productionDate.ToString("yyyy-MM-dd"),
                            ExpirationDate = i.ExpirationDate.ToString("yyyy-MM-dd")
                        };

            return query.Cast<dynamic>().ToList();
        }
        public List<dynamic> GetItemsExpiringSoon(int daysThreshold, int warehouseId)
        {
            DateTime soonDate = DateTime.Now.AddDays(daysThreshold);

            return inventoryDb.warehouseItems
                .Include(wi => wi.Warehouse)
                .Include(wi => wi.Item)
                .Include(wi => wi.Unit)
                .Where(wi =>
                    wi.Warehouse.WarehouseID == warehouseId &&      
                    wi.ExpirationDate > DateTime.Now &&             
                    wi.ExpirationDate <= soonDate &&                
                    wi.quntity > 0)                                 
                .Select(wi => new
                {
                    ItemName = wi.Item.Name,
                    Quantity = wi.quntity.ToString() + " " + wi.Unit.Name,
                    ProductionDate = wi.productionDate.ToString("yyyy-MM-dd"),
                    ExpirationDate = wi.ExpirationDate.ToString("yyyy-MM-dd"),
                    DaysUntilExpiration = EF.Functions.DateDiffDay(DateTime.Now, wi.ExpirationDate)
                })
                .Cast<dynamic>()
                .ToList();
        }
        public List<dynamic> GetItemsExpiringSoonAllWarehouses(int daysThreshold)
        {
            DateTime soonDate = DateTime.Now.AddDays(daysThreshold);

            return inventoryDb.warehouseItems
                .Include(wi => wi.Warehouse)
                .Include(wi => wi.Item)
                .Include(wi => wi.Unit)
                .Where(wi =>
                    wi.ExpirationDate > DateTime.Now &&            
                    wi.ExpirationDate <= soonDate &&             
                    wi.quntity > 0)                                 
                .Select(wi => new
                {
                    WarehouseName = wi.Warehouse.Name,
                    ItemName = wi.Item.Name,
                    Quantity = wi.quntity.ToString() + " " + wi.Unit.Name,
                    ProductionDate = wi.productionDate.ToString("yyyy-MM-dd"),
                    ExpirationDate = wi.ExpirationDate.ToString("yyyy-MM-dd"),
                    DaysUntilExpiration = EF.Functions.DateDiffDay(DateTime.Now, wi.ExpirationDate)
                })
                .Cast<dynamic>()
                .ToList();
        }
       
        public List<dynamic> getAllWarehousesItem(DateTime fromDate, DateTime toDate)
        {
            var query = (from w in inventoryDb.warehouses
                         from i in w.warehouseItems
                         where i.productionDate >= fromDate && i.productionDate <= toDate && i.quntity > 0
                         select new
                         {
                             warehouse_name = w.Name,
                             ItemName = i.Item.Name,
                             quntity = i.quntity.ToString() + " " + i.Unit.Name,
                             productionDate = i.productionDate.ToString("yyyy-MM-dd"),
                             ExpirationDate = i.ExpirationDate.ToString("yyyy-MM-dd")
                         }).Cast<dynamic>().ToList();
            return query;
        }
        public List<Employee> getAllEmployees()
        {
            return employeeControl.getAllEmployees();
        }
    }
}
