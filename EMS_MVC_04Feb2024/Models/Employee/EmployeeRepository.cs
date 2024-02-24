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
        public List<EmployeeModel> GetEmployees
        {
            get
            {
               return context.Employees.ToList();
            }
        }
    }
}