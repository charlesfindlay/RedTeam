using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using RedTeam.Helper;

namespace RedTeam.Models
{
    public class Roku
    {
        public IPAddress Location { get; set; }
        public List<Channel> favorite { get; set; }
        public List<Channel> installedApp { get; set; }


        public Roku()
        {
            this.favorite = new List<Channel>();
            this.installedApp = new List<Channel>();

        }
    }
}