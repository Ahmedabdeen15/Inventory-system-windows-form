using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.data
{
    [Table("Supplied_item")]
    class SuppliedItem
    {
        [Key]
        public int ID { get; set; }

        public float quntity { get; set; }

        public DateTime ProudctionDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public int expirationDays { get; set; }
        [NotMapped]
        public int ExpirationDays {
            set {
                ExpirationDate = ProudctionDate.AddDays(value);
                expirationDays = value;
            }
            get
            {
                return expirationDays;
            }
        }

        public Item Item { get; set; }


        public Unit Unit { get; set; }

        public WarehouseItem WarehouseItem { get; set; }

        public supplyPermit supplyPermit { get; set; }

    }
}
