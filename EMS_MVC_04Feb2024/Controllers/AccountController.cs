using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace EMS_MVC_04Feb2024.Controllers
{
    public class AccountController : BaseController
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
       // [ValidateAntiForgeryToken]
        public ActionResult Login(string UserId,string Password)
        {
            if(UserId == "admin" && Password == "123456")
            {
                FormsAuthentication.RedirectFromLoginPage(UserId, false);
            }
            Notify("Invalid Credentials", "Incorrect userid or password!", MessagetType.error);
            return View();
        }
    }
}