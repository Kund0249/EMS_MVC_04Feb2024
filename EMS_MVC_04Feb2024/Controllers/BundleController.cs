using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EMS_MVC_04Feb2024.Controllers
{
    [AllowAnonymous]
    public class BundleController : Controller
    {
        // GET: Bundle
        public ActionResult Index()
        {
            return View();
        }
    }
}