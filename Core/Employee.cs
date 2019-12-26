using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Core
{
    public class Employee
    {
        public int EmpId { get; set; }
        [Required]
        [MaxLength(5, ErrorMessage ="Name should be 5 char long")]
        public string EmpName { get; set; }
    }
}
