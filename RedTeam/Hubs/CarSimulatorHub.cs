using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace RedTeam.Hubs
{
    public class CarSimulatorHub : Hub
    {
        private Broadcaster _broadcaster;

        public void doorLock(bool locked)
        {
            Clients.All.doorLock(locked);
        }

        public void carLight(bool off)
        {
            Clients.All.carLight(off);
        }

        public void carEngine(bool off)
        {
            Clients.All.carEngine(off);
        }
    }
    
    
}