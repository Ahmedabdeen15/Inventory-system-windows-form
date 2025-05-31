using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.model
{
    [Table("supply_Permit")]
    class supplyPermit
    {
        [Key]
        public int PermitId { get; set; }

        public DateTime SupplyDate { get; set; }

        public string permitNumber { get; set; }

        public Supplier Supplier { get; set; }

        public Warehouse Warehouse { get; set; }

    }
}
