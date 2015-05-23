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
            // Once the code for the listener is working then the IP address of the roku needs to be passed into the view.
            // but for now it is hardcoded.
            RedTeam.Helper.FindRoku.HearRoku();
            //var myRoku = "192.168.0.101"; // 192.168.0.101 is Charles' home roku
            
            return View();
        }

        


    }
}