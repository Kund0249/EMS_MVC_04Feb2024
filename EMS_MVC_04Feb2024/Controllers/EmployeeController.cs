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
        //[Route("Employee")]
        public ActionResult Index()
        {
            return View(repository.GetEmployees);
        }

      //  [Route("Employee/add")]
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
            if (ModelState.IsValid)
            {
                //Realative Path
                string Folder = "~/EmpImages";
                string guidId = Guid.NewGuid().ToString();
                string FileName = guidId + "_" + model.ImageFile.FileName;
                string ImagePath = System.IO.Path.Combine(Server.MapPath(Folder), FileName);
                model.ImageFile.SaveAs(ImagePath);
                model.ProfileImage = FileName;

                //string extension = System.IO.Path.GetExtension(FileName);
                //int contentlength = model.ImageFile.ContentLength; //Ikb = 1024 byte ,1MB = 1024KB => 2*1024*1024
                //if(contentlength <= (2 * 1024 * 1024))
                //{
                //    model.ImageFile.SaveAs(ImagePath);
                //    model.ProfileImage = FileName;
                //}

                if(repository.Add(model,out string message))
                {
                    Notify("Success", message, MessagetType.success);
                    return RedirectToAction(nameof(Index));
                }
                Notify("Error", message, MessagetType.error);
            }
            Notify("Warrining", "Please upload profile Image", MessagetType.warrning);
            model.Departments = Drepository.Departments.
                                   Select(x => new SelectListItem()
                                   {
                                       Text = x.DepartmentName,
                                       Value = x.DepartmentId.ToString()
                                   }).ToList();
            return View(model);
        }
    }
}
