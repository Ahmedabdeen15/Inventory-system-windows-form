using Inventory.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.controller
{
    internal class WarehouseControl
    {
        InventoryDbContext inventoryDb;
        EmployeeControl employeeControl;

        public WarehouseControl(InventoryDbContext inventoryDb) {
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
        public List<Employee> getAllEmployees()
        {
            return employeeControl.getAllEmployees();
        }
    }
}
