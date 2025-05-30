using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.model
{
    [Table("Unit_items")]
    class Unit_item
    {
        public Unit unit {  get; set; }
        public Item item { get; set; }
    }
}
