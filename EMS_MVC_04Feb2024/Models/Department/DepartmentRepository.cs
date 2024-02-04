using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMS_MVC_04Feb2024.Models.Department
{
    public class DepartmentRepository
    {
        public List<DepartmentModel> Departments
        {
            get
            {
                return new List<DepartmentModel>()
            {
                new DepartmentModel(){DepartmentId=1,DepartmentCode="IT",DepartmentName="Information Technology"},
                new DepartmentModel(){DepartmentId=2,DepartmentCode="CS",DepartmentName="Computer Science"},
                new DepartmentModel(){DepartmentId=3,DepartmentCode="BR",DepartmentName="Brokerage Management"}
            };
            }

        }

        public bool Save(DepartmentModel model,out string Message)
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

        public bool Update(DepartmentModel model, out string Message)
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