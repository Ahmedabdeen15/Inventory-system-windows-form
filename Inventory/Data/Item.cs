using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.data
{
    [Table("items")]
    class Item
    {
        public Item()
        {
            units = new HashSet<Unit>();
        }
        [Key]
        public int ItemId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ItemCode { get; set; }

        public ICollection<Unit> units { get; set; }

    }
}
