using EMS_MVC_04Feb2024.CustomFiletrs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EMS_MVC_04Feb2024.App_Start
{
    public class FilterConfig 
    {
        public static void RegisterFilters()
        {
            //GlobalFilters.Filters.Add(new HandleErrorAttribute());
            GlobalFilters.Filters.Add(new CustomHandleError());
        }
    }
}