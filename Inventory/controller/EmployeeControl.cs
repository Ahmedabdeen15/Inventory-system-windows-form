using Inventory.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.controller
{
    internal class EmployeeControl
    {
        InventoryDbContext inventoryDb;

        public EmployeeControl(InventoryDbContext inventoryDb) {
            this.inventoryDb = inventoryDb;
        }
        public void insertEmployee(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name cannot be null or empty");
            }
            Employee employee = new Employee
            {
                Name = name
            };
            inventoryDb.employees.Add(employee);
            inventoryDb.SaveChanges();
        }
        public void updateEmployee(int empId, string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name cannot be null or empty");
            }
            Employee employee = inventoryDb.employees.Find(empId);
            if (employee == null)
            {
                throw new KeyNotFoundException("Employee not found");
            }
            employee.Name = name;
            inventoryDb.SaveChanges();
        }
        public List<Employee> getAllEmployees()
        {
            return inventoryDb.employees.ToList();
        }
    }
}
