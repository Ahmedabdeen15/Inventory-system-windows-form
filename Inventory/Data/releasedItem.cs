using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.data
{
    [Table("released_item")]
    class releasedItem
    {
        [Key]
        public int ID {  get; set; }

        public float quntity { get; set; }

        public WarehouseItem warehouseItem { get; set; }

        public ReleasePermit ReleasePermit { get; set; }
    }
}
