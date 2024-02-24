using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using EMS_MVC_04Feb2024.Models.Department;
using System.Web.Mvc;

namespace EMS_MVC_04Feb2024.Models.Employee
{
    [Table("TEMPLOYEE")]
    public class EmployeeModel
    {
       
        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public string Gender { get; set; }
        public string ContactNo { get; set; }
        public DateTime DOJ { get; set; }
        public string EmailAddress { get; set; }
        public int? Salary { get; set; }
        public string BankAccountNo { get; set; }
        public string ProfileImage { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }

        [NotMapped]
        public List<SelectListItem> Departments { get; set; }

        //Navigation Properties
        public DepartmentModel Department { get; set; }
    }
}