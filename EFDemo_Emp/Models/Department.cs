﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo_Emp.Models
{
    internal class Department
    {
        [Key]
        public int Id { get; set; }
        public string? DeptName { get; set; }
        [ForeignKey("DepartmentId")]
        public IList<Employee?> Employees { get; set; }
    }
}
