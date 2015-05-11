using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedTeam.Models
{
    public class CarSimulator
    {
        public bool doorLock { get; set; }
        public string speed { get; set; }

        public CarSimulator()
        {
            this.doorLock = false;
            
        }
    
    
    }

}