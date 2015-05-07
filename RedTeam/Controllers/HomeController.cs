using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedTeam.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        
        {
            return View();
        }

        public ActionResult RokuRemote()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult CarRemote()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}