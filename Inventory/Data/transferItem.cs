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

        public DateTime ProudctionDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        [NotMapped]
        public int ExpirationDays
        {
            set
            {
                ExpirationDate = ProudctionDate.AddDays(value);
                ExpirationDays = value;
            }
            get
            {
                return ExpirationDays;
            }
        }

        public Item Item { get; set; }


        public Unit Unit { get; set; }

        public Supplier supplier { get; set; }

        public Warehouse FromWarehouse { get; set; }

        public Warehouse ToWarehouse { get; set; }

    }
}
