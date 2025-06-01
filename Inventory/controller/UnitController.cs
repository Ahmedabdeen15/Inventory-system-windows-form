using Inventory.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.controller
{
    internal class UnitController
    {
        InventoryDbContext dbContext;
        public UnitController(InventoryDbContext dbContext) { 
            this.dbContext = dbContext;
        }

        public void insertUnit(String name) { 
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name can't be empty");
            }
            dbContext.units.Add(
                new Unit
                {
                    Name = name
                });
            dbContext.SaveChanges();
        }

        public void updateUnit(int id,String name)
        {
            if (string.IsNullOrEmpty(name) | id < 0 )
            {
                throw new ArgumentNullException("name can't be empty");
            }
            Unit unit = dbContext.units.Find(id);
            if (unit == null) {
                throw new KeyNotFoundException("Item not found");
            }
            unit.Name = name;
            dbContext.SaveChanges();
        }
        public List<Unit> getAllUnits()
        {
            return dbContext.units.ToList();
        }
    }
}
