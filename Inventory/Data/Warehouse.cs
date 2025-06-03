using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.data
{
    [Table("Warehouses")]
    class Warehouse
    {
        [Key]
        public int WarehouseID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public Employee manger { get; set; }

        public List<WarehouseItem> warehouseItems { get; set; } = new List<WarehouseItem>();

        public List<supplyPermit> supplyPermits
        {
            get; set;
        } = new List<supplyPermit>();

    }
}
