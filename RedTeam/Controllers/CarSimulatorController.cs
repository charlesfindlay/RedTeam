using RedTeam.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedTeam.Controllers
{
    public class CarSimulatorController : Controller
    {
        // GET: CarSimulator
        public ActionResult Index()
        {
            var model = Broadcaster.Instance.GetCarModel();
            return View(model);
        }
    }
}