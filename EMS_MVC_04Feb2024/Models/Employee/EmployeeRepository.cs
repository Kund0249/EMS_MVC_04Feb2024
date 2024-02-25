using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMS_MVC_04Feb2024.Models.Employee
{
    public class EmployeeRepository
    {
        private readonly DataContext context;
        public EmployeeRepository()
        {
            context = new DataContext();
        }
        public List<EmployeeVM> GetEmployees
        {
            get
            {
               return context.Employees.Select(x => new EmployeeVM(){
                   EmployeeId = x.EmployeeId,
                   Name = x.Name,
                   Gender = x.Gender,
                   ContactNo = x.ContactNo,
                   EmailAddress = x.EmailAddress,
                   DOJ = x.DOJ,
                   Salary = x.Salary,
                   BankAccountNo = x.BankAccountNo,
                   ProfileImage = (x.ProfileImage != null ? "~/EmpImages/" + x.ProfileImage : "")
               }).ToList();
            }
        }

        public bool Add(EmployeeModel employee,out string Message)
        {
            try
            {
                Message = string.Empty;
                context.Employees.Add(employee);
                context.SaveChanges();
                Message = "Record Created!";
                return true;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                return false;
                
            }
        }
    }
}