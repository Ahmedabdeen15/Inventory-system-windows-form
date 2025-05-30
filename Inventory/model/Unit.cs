using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.model
{
    [Table("Units")]
    class Unit
    {
        [Key]
        public int UnitId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
