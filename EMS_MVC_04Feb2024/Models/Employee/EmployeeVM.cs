using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMS_MVC_04Feb2024.Models.Employee
{
    public class EmployeeVM
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string ContactNo { get; set; }
        public DateTime DOJ { get; set; }
        public string EmailAddress { get; set; }
        public int? Salary { get; set; }
        public string BankAccountNo { get; set; }
        public string ProfileImage { get; set; }
    }
}