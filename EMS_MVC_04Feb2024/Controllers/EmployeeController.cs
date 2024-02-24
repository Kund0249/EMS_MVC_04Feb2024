using EMS_MVC_04Feb2024.Models;
using EMS_MVC_04Feb2024.Models.Department;
using EMS_MVC_04Feb2024.Models.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EMS_MVC_04Feb2024.Controllers
{
    public class EmployeeController : BaseController
    {
        private readonly EmployeeRepository repository;
        private readonly DepartmentRepository Drepository;
        //private readonly DataContext context;
        public EmployeeController()
        {
            repository = new EmployeeRepository();
            Drepository = new DepartmentRepository();
        }
        // GET: Employee
        public ActionResult Index()
        {
            return View(repository.GetEmployees);
        }

        [HttpGet]
       public ActionResult Create()
        {
            EmployeeModel model = new EmployeeModel();
            model.Departments = Drepository.Departments.
                                    Select(x => new SelectListItem() { 
                                   Text = x.DepartmentName,
                                   Value = x.DepartmentId.ToString()
                                }).ToList();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel  model)
        {
            return View();
        }
    }
}
