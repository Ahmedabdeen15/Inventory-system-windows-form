using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.data;
using Microsoft.EntityFrameworkCore;

namespace Inventory.controller
{

    internal class PermitQueryController
    {
        private readonly InventoryDbContext inventoryDb;

        public PermitQueryController(InventoryDbContext context)
        {
            this.inventoryDb = context;
        }

        public List<dynamic> GetAllPermits(List<int> warehouseIds = null, int? itemId = null)
        {
            var supplyPermits = inventoryDb.supplyPermits
                .Include(p => p.Warehouse)
                .Include(p => p.Supplier)
                .Include(p => p.suppliedItems)
                    .ThenInclude(si => si.Item)
                .Include(p => p.suppliedItems)
                    .ThenInclude(si => si.Unit)
                .Where(p =>
                    (warehouseIds == null || warehouseIds.Count == 0 || warehouseIds.Contains(p.Warehouse.WarehouseID)) &&
                    (itemId == null || p.suppliedItems.Any(si => si.Item.ItemId == itemId)))
                .Select(p => new
                {
                    PermitType = "Supply",
                    PermitId = p.PermitId,
                    Date = p.SupplyDate,
                    PermitNumber = p.permitNumber,
                    WarehouseName = p.Warehouse.Name,
                    PartyName = p.Supplier.name,
                    Items = p.suppliedItems.Select(si => new
                    {
                        ItemName = si.Item.Name,
                        Quantity = si.quntity.ToString() + " " + si.Unit.Name,
                        ProductionDate = si.ProudctionDate.ToString("yyyy-MM-dd"),
                        ExpirationDate = si.ExpirationDate.ToString("yyyy-MM-dd")
                    })
                });

            var releasePermits = inventoryDb.releasePermits
                .Include(p => p.Warehouse)
                .Include(p => p.Customer)
                .Include(p => p.releasedItems)
                    .ThenInclude(ri => ri.warehouseItem)
                        .ThenInclude(wi => wi.Item)
                .Include(p => p.releasedItems)
                    .ThenInclude(ri => ri.warehouseItem)
                        .ThenInclude(wi => wi.Unit)
                .Where(p =>
                    (warehouseIds == null || warehouseIds.Count == 0 || warehouseIds.Contains(p.Warehouse.WarehouseID)) &&
                    (itemId == null || p.releasedItems.Any(ri => ri.warehouseItem.Item.ItemId == itemId)))
                .Select(p => new
                {
                    PermitType = "Release",
                    PermitId = p.PermitId,
                    Date = p.ReleaseDate,
                    PermitNumber = p.permitNumber,
                    WarehouseName = p.Warehouse.Name,
                    PartyName = p.Customer.name,
                    Items = p.releasedItems.Select(ri => new
                    {
                        ItemName = ri.warehouseItem.Item.Name,
                        Quantity = ri.quntity.ToString() + " " + ri.warehouseItem.Unit.Name,
                        ProductionDate = ri.warehouseItem.productionDate.ToString("yyyy-MM-dd"),
                        ExpirationDate = ri.warehouseItem.ExpirationDate.ToString("yyyy-MM-dd")
                    })
                });

            return supplyPermits.Union(releasePermits)
                .OrderByDescending(p => p.Date)
                .Cast<dynamic>()
                .ToList();
        }

        public List<dynamic> GetAllItemLocations(List<int> warehouseIds = null, int? itemId = null)
        {
            return inventoryDb.warehouseItems
                .Include(wi => wi.Warehouse)
                .Include(wi => wi.Item)
                .Include(wi => wi.Unit)
                .Where(wi =>
                    (warehouseIds == null || warehouseIds.Count == 0 || warehouseIds.Contains(wi.Warehouse.WarehouseID)) &&
                    (itemId == null || wi.Item.ItemId == itemId))
                .Select(wi => new
                {
                    ItemId = wi.Item.ItemId,
                    ItemName = wi.Item.Name,
                    WarehouseName = wi.Warehouse.Name,
                    Quantity = wi.quntity.ToString() + " " + wi.Unit.Name,
                    ProductionDate = wi.productionDate.ToString("yyyy-MM-dd"),
                    ExpirationDate = wi.ExpirationDate.ToString("yyyy-MM-dd")
                })
                .Cast<dynamic>()
                .ToList();
        }

        public List<dynamic> GetItemMovementHistory(int itemId, List<int> warehouseIds = null)
        {
            var supplyMovements = inventoryDb.supplyPermits
                .Include(p => p.Warehouse)
                .Include(p => p.Supplier)
                .Include(p => p.suppliedItems)
                    .ThenInclude(si => si.Item)
                .Where(p =>
                    p.suppliedItems.Any(si => si.Item.ItemId == itemId) &&
                    (warehouseIds == null || warehouseIds.Count == 0 || warehouseIds.Contains(p.Warehouse.WarehouseID)))
                .SelectMany(p => p.suppliedItems
                    .Where(si => si.Item.ItemId == itemId)
                    .Select(si => new
                    {
                        Date = p.SupplyDate,
                        MovementType = "Supply",
                        PermitNumber = p.permitNumber,
                        WarehouseName = p.Warehouse.Name,
                        PartyName = p.Supplier.name,
                        Quantity = si.quntity,
                        Unit = si.Unit.Name
                    }));

            var releaseMovements = inventoryDb.releasePermits
                .Include(p => p.Warehouse)
                .Include(p => p.Customer)
                .Include(p => p.releasedItems)
                    .ThenInclude(ri => ri.warehouseItem)
                        .ThenInclude(wi => wi.Item)
                .Where(p =>
                    p.releasedItems.Any(ri => ri.warehouseItem.Item.ItemId == itemId) &&
                    (warehouseIds == null || warehouseIds.Count == 0 || warehouseIds.Contains(p.Warehouse.WarehouseID)))
                .SelectMany(p => p.releasedItems
                    .Where(ri => ri.warehouseItem.Item.ItemId == itemId)
                    .Select(ri => new
                    {
                        Date = p.ReleaseDate,
                        MovementType = "Release",
                        PermitNumber = p.permitNumber,
                        WarehouseName = p.Warehouse.Name,
                        PartyName = p.Customer.name,
                        Quantity = -ri.quntity, // Negative for releases
                        Unit = ri.warehouseItem.Unit.Name
                    }));

            return supplyMovements.Union(releaseMovements)
                .OrderByDescending(m => m.Date)
                .Cast<dynamic>()
                .ToList();
        }
        public List<dynamic> GetItemsBySupplyAge(int daysThreshold, int warehouseId)
        {
            DateTime thresholdDate = DateTime.Now.Date.AddDays(-daysThreshold);

            return inventoryDb.supplyPermits
                .Include(sp => sp.Warehouse)
                .Include(sp => sp.suppliedItems)
                    .ThenInclude(si => si.Item)
                .Include(sp => sp.suppliedItems)
                    .ThenInclude(si => si.Unit)
                .Where(sp =>
                    sp.Warehouse.WarehouseID == warehouseId && 
                    sp.SupplyDate == thresholdDate)            
                .SelectMany(sp => sp.suppliedItems
                    .Select(si => new
                    {
                        ItemName = si.Item.Name,
                        Quantity = si.quntity.ToString() + " " + si.Unit.Name,
                        SupplyDate = sp.SupplyDate.ToString("yyyy-MM-dd"),
                        ProductionDate = si.ProudctionDate.ToString("yyyy-MM-dd"),
                        ExpirationDate = si.ExpirationDate.ToString("yyyy-MM-dd"),
                        DaysInWarehouse = EF.Functions.DateDiffDay(sp.SupplyDate, DateTime.Now),
                        PermitNumber = sp.permitNumber,
                        RemainingDays = EF.Functions.DateDiffDay(DateTime.Now, si.ExpirationDate)
                    }))
                .Cast<dynamic>()
                .ToList();
        }
    }
}
