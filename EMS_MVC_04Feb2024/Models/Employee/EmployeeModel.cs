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

        [Required(ErrorMessage ="Name is mandatory")]
        [RegularExpression("[a-zA-Z\\s]*",ErrorMessage ="only alphabets are allowed")]
        [StringLength(50,ErrorMessage ="Name should not longer that 50 char")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please select department")]
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Please select gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please enter contact number")]
        [RegularExpression("[6-9]{1}[0-9]{9}",ErrorMessage ="Please enter valid contact number")]
        public string ContactNo { get; set; }

        [Required]
        public DateTime DOJ { get; set; }

        [Required]
        [EmailAddress(ErrorMessage ="Please enter valid email")]
        public string EmailAddress { get; set; }
        public int? Salary { get; set; }
        public string BankAccountNo { get; set; }
        public string ProfileImage { get; set; }

        [NotMapped]
        [Required(ErrorMessage ="please select profile image")]
        public HttpPostedFileBase ImageFile { get; set; }

        [NotMapped]
        public List<SelectListItem> Departments { get; set; }

        //Navigation Properties
        public DepartmentModel Department { get; set; }
    }
}