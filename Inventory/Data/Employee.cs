using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.data
{
    [Table("Employee")]
    class Employee
    {
        [Key]
        public int EmpId { get; set; }
        [Required]
        [StringLength(10)]
        public string Name { get; set; }
    }
}
