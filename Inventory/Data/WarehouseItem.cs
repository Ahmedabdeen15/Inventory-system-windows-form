using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.data
{
    [Table("WarehouseItem")]
    class WarehouseItem
    {
        [Key]
        public int Id { get; set; }

        public float quntity { get; set; }

        //problem here
        public DateTime productionDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public Item Item { get; set; }

        public Warehouse Warehouse { get; set; }

        public Unit Unit { get; set; }

        public List<SuppliedItem> suppliedItems { get; set; } = new List<SuppliedItem>();

    }
}
