using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WindowAuth.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if (User.IsInRole(@"BUILTIN\Administrators") || User.IsInRole(@"DOMAIN\Vanphong"))
            {
                ViewBag.isAdmin = "Là admin";
            }
            else
            {
                ViewBag.isAdmin = "ko admin";
            }
            return View();
        }
    }
}