using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.model
{
    [Table("released_item")]
    class releasedItem
    {
        [Key]
        public int ID {  get; set; }

        public float quntity { get; set; }

        public DateTime ExpirationDate { get; set; }


        public Item Item { get; set; }


        public Unit Unit { get; set; }

        public ReleasePermit ReleasePermit { get; set; }
    }
}
