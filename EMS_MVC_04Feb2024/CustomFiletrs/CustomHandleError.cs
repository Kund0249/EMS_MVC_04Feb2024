using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EMS_MVC_04Feb2024.CustomFiletrs
{
    public class CustomHandleError : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            Exception exception = filterContext.Exception;
            Log(exception);
            base.OnException(filterContext);
        }

        private void Log(Exception ex)
        {
            //logic
        }
    }
}