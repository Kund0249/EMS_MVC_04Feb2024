using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EMS_MVC_04Feb2024.Models;

namespace EMS_MVC_04Feb2024.Models.Department
{
    public class DepartmentRepository
    {
        private readonly DataContext context;
        public DepartmentRepository()
        {
            context = new DataContext();
        }
        public List<DepartmentModel> Departments
        {
            get
            {
              return  context.Departments.ToList();
            }

        }

        public DepartmentModel Find(int Id)
        {
           return context.Departments.FirstOrDefault(x => x.DepartmentId == Id);
        }
        public bool Save(DepartmentModel model,out string Message)
        {
            Message = string.Empty;
            try
            {
                //save
              var data =  context.Departments.SingleOrDefault(x => 
                x.DepartmentCode == model.DepartmentCode 
                || x.DepartmentName == model.DepartmentName);

                if(data != null)
                {
                    Message = "Record already exist!";
                    return false;
                }
                context.Departments.Add(model);
                context.SaveChanges();
                Message = "Record created sucessfully!";
                return true;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                return false;
            }
        }

        public bool Update(DepartmentModel model, out string Message)
        {
            Message = string.Empty;
            try
            {
                //save
               var department = context.Departments.SingleOrDefault(x => x.DepartmentId == model.DepartmentId);
                if(department != null)
                {
                    department.DepartmentCode = model.DepartmentCode;
                    department.DepartmentName = model.DepartmentName;
                    context.SaveChanges();
                    Message = "Department Updated";
                    return true;
                }
                Message = "Department Not Found!";
                return false;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                return false;
            }
        }

        public bool Remove(int DepartmentId, out string Message)
        {
            Message = string.Empty;
            try
            {
                //save

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