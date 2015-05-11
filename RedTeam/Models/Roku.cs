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
        public string Location { get; set; }
        public List<Channel> favorite { get; set; }

        public Roku()
        {
            this.favorite = new List<Channel>();
        }
    }
}