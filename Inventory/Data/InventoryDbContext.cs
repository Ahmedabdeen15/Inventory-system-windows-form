using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Inventory.data
{
    class InventoryDbContext : DbContext
    {
        public InventoryDbContext() { }
        public InventoryDbContext(DbContextOptions<InventoryDbContext> options)
            : base(options){}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source= .\\SQLEXPRESS; initial catalog = inventory ; integrated security = true ; TrustServerCertificate=True;");
        }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Employee> employees { get; set; }

        public DbSet<Item> items { get; set; }

        public DbSet<releasedItem> releasedItems { get; set; }

        public DbSet<ReleasePermit> releasePermits { get; set; }

        public DbSet<SuppliedItem> suppliedItems { get; set; }

        public DbSet<supplyPermit> supplyPermits { get; set; }

        public DbSet<Supplier> suppliers { get; set; }

        public DbSet<transferItem> transferItems { get; set; }

        public DbSet<Unit> units { get; set; }

        

        public DbSet<Warehouse> warehouses { get; set; }
        public DbSet<WarehouseItem> warehouseItems { get; set; }


    }
}
