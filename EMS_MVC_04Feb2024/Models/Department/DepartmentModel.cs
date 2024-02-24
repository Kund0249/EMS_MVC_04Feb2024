using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EMS_MVC_04Feb2024.Models.Employee;

namespace EMS_MVC_04Feb2024.Models.Department
{
    [Table("TDEPARTMENT")]
    public class DepartmentModel
    {
        [Key]
        public int DepartmentId { get; set; }

       // [Column("DepartmentCode")]
        public string DepartmentCode { get; set; }

        //[Column("DepartmentName")]
        public string DepartmentName { get; set; }

        //Navigation Properties
        public ICollection<EmployeeModel> Employees { get; set; }


    }
}