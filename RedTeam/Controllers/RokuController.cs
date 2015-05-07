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
        public Roku myRoku = new Roku();

        // GET: Roku
        public ActionResult Index()
        {

            //RedTeam.Helper.FindRoku.HearRoku();
            
            //Add default favorite channels
            myRoku.favorite.Add(new Channel(12));
            myRoku.favorite.Add(new Channel(13));
            myRoku.favorite.Add(new Channel(26950));
            myRoku.favorite.Add(new Channel(23333));
            myRoku.favorite.Add(new Channel(28076));

            ViewBag.myfavorites = myRoku.favorite;

            return View();
        }

        


    }
}