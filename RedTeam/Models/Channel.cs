using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RedTeam.Models
{
    public class Channel
    {
        public int appID { get; set; }
        
        public Channel(int p)
        {
            // TODO: Complete member initialization
            this.appID = p;
        }
    }
}
