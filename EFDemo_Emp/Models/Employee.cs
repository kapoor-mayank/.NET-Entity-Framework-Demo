using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo_Emp.Models
{
    internal class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string? Name { get; set; }
        public double? Salary { get; set; }
        [ForeignKey("Department")]
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}
