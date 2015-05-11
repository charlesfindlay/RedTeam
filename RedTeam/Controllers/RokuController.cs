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
using System.Xml.XPath;

namespace RedTeam.Controllers
{
    public class RokuController : Controller
    {
        public Roku myRoku = new Roku();

        // GET: Roku
        public ActionResult Index()
        {
            var whereRoku = "192.168.0.105"; //delete this line and uncomment the next line when listener is working
            //var whereRoku = RedTeam.Helper.FindRoku.HearRoku();  
            GetInstalledChannels(whereRoku, myRoku);
            
            //Add default favorite channels
            myRoku.favorite.Add(new Channel(12));
            myRoku.favorite.Add(new Channel(13));
            myRoku.favorite.Add(new Channel(26950));
            myRoku.favorite.Add(new Channel(23333));
            myRoku.favorite.Add(new Channel(28076));

            ViewBag.myfavorites = myRoku.favorite;

            return View();
        }

        private List<Channel> GetInstalledChannels(string whereRoku, Roku myRoku)
        {
            string installedQuery = "http://" + whereRoku + ":8060/query/apps";

            XPathDocument xmlRokuPathDoc = new XPathDocument(installedQuery);

            XPathNavigator rokuNav = xmlRokuPathDoc.CreateNavigator();

            XPathNodeIterator xRokuPathIt = rokuNav.Select("//app/id");

            while (xRokuPathIt.MoveNext())
            {
                int nextApp = Convert.ToInt32(xRokuPathIt.Current.Value);
                myRoku.installedApp.Add(new Channel(nextApp));
            }

            
        }

        


    }
}