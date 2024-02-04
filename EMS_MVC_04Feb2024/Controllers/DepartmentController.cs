using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using EMS_MVC_04Feb2024.Models.Department;

namespace EMS_MVC_04Feb2024.Controllers
{
    public class DepartmentController : Controller
    {
        //Declaration
        private readonly DepartmentRepository _repository;

        //Initilization
        public DepartmentController()
        {
            _repository = new DepartmentRepository();
        }

        //Endpoint or Action Method
        //[Controller]/[ActionName]
        //Department/GetDepartment

        [HttpGet]
        public ViewResult Index()
        {
            List<DepartmentModel> departments = _repository.Departments;
            return View("GetDepartment", departments);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Create(DepartmentModel department)
        {
            //save
            return View();
            //return RedirectToAction("Index");
        }
    }
}