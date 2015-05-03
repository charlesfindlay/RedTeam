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
        public IPAddress Location { get { return FindRoku.HearRoku(); } }


    }
}