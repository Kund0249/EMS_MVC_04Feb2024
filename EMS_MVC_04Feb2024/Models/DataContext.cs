using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EMS_MVC_04Feb2024.Models
{
    public class DataContext : DbContext
    {
        public DataContext():base("name=DBCON")
        {

        }

        public DbSet<Department.DepartmentModel> Departments { get; set; }
    }
}