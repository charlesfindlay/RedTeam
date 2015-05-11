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
        public void SendSpeed(string speed)
        {

            _broadcaster.SendCurrentSpeed(speed);
        }
        //public void SendSpeed(int speed)
        //{
        //    // Call the broadcastSpeed method to update clients.
        //    Clients.All.broadcastSpeed(speed);
        //}

    }
    
    
}