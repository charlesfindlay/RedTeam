using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedTeam.Models
{
    public class CarSimulator
    {
        public bool doorLock { get; set; }
        public bool carLight { get; set; }
        public bool carEngine { get; set; }
        public int speed { get; set; }
        public int gasLevel { get; set; }
        public int rangeRemaining { get; set; }

        public CarSimulator()
        {
            this.doorLock = false;
            this.carLight = false;
            this.carEngine = false;
            this.speed = 100;
            this.gasLevel = 16;
            this.rangeRemaining = 432;
        }

    }
}