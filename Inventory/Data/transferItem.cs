using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.data
{
    [Table("transfer_Items")]
    class transferItem
    {
        [Key]
        public int ID { get; set; }

        public float quntity { get; set; }

       public WarehouseItem warehouseItem { get; set; }

        public Supplier supplier { get; set; }

        public Warehouse FromWarehouse { get; set; }

        public Warehouse ToWarehouse { get; set; }

    }
}
