using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.model
{
    [Table("suppliers")]
    class Supplier
    {
        [Key]
        public int SupplierID { get; set; }

        [Required]
        public string name { get; set; }

        [Required]

        public string phone { get; set; }
        public string fax { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        [DataType(DataType.Url)]
        public string website { get; set; }




    }
}
