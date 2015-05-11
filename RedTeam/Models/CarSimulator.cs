using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedTeam.Models
{
    public class CarSimulator
    {
        public bool doorLock { get; set; }
        public bool headLight { get; set; }


        public CarSimulator()
        {
            this.doorLock = false;
            this.headLight = false;
            this.carEngine = false;
        }





        public object carLight { get; set; }

        public bool carEngine { get; set; }
    }

}