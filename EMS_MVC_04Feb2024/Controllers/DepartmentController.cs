using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using EMS_MVC_04Feb2024.Models.Department;


namespace EMS_MVC_04Feb2024.Controllers
{
    //[HandleError]
    [Authorize]
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
        [OutputCache(Duration =30)]
        //[HandleError]
        public ViewResult Index()
        {
            List<DepartmentModel> departments = _repository.Departments;
            //throw new Exception("There is custom error");
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


       public ActionResult Edit(int id)
        {
           var Department = _repository.Find(id);
            if(Department != null)
               return View(Department);

            Notify("Not Found", $"Department with id : {id} not found", MessagetType.warrning);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public ActionResult Edit(DepartmentModel model)
        {
           if(_repository.Update(model,out string message))
            {
                Notify("Record Updated",message, MessagetType.success);
            }
            else
            {
                Notify("Record not Updated", message, MessagetType.error);
            }

           // Notify("Not Found", $"Department with id : {id} not found", MessagetType.warrning);
            return RedirectToAction(nameof(Index));
        }
    }
}