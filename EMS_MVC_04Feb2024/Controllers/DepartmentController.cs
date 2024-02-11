using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using EMS_MVC_04Feb2024.Models.Department;


namespace EMS_MVC_04Feb2024.Controllers
{
    public class DepartmentController : BaseController
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
        public ActionResult Create(DepartmentModel department)
        {
            //save
            var JS = new JavaScriptSerializer();
            if (_repository.Save(department,out string Message))
            {

                //var message = new
                //{
                //    Message = Message,
                //    Title = "Record Save",
                //    Type = "success"
                //};

                //TempData["Message"] = JS.Serialize(message);
                Notify("Record Save", Message, MessagetType.success);
                return RedirectToAction("Index");
            }
            //var _message = new
            //{
            //    Message = Message,
            //    Title = "Error Occur",
            //    Type = "error"
            //};
            //TempData["Message"] = JS.Serialize(_message);
            Notify("Error Occur", Message, MessagetType.error);
            return View(department);
            
        }
    }
}