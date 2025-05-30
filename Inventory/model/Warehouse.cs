using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.model
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

    }
}
