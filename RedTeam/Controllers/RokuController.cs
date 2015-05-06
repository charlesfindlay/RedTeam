using RedTeam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Web.Http;

namespace RedTeam.Controllers
{
    public class RokuController : Controller
    {

        // GET: Roku
        public ActionResult Index()
        {

            //RedTeam.Helper.FindRoku.HearRoku();
            //var myFavorites = new List<Channel>  // Hard code favorite channels for testing of quick links
            //{
            //    new Channel(12),
            //    new Channel(13),
            //    new Channel(26950),
            //    new Channel(23333),
            //    new Channel(28076)
            //};


            return View();
        }

        


    }
}