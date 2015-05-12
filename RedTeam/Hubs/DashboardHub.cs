using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using RedTeam.Models;

namespace RedTeam.Hubs
{
    public class DashboardHub : Hub
    {
        public Broadcaster _broadcaster;

         public DashboardHub() 
            : this(Broadcaster.Instance) 
        { 
        }

        public DashboardHub(Broadcaster broadcaster) 
        { 
            _broadcaster = broadcaster; 
        }


        public void DoorLockCmd(bool myCarIsLocked)
        {
            _broadcaster.SendLockCmd(myCarIsLocked);
        }
        public void SendASpeed(int speed)
        {
            // Call the sendSpeed method to update clients.
            Clients.All.SendSpeed(speed);
        }
        public void SendAGasLevel(int gas)
        {
            // Call the sendGas method to update clients.
            Clients.All.SendGas(gas);
        }
        //public void BroadcastSpeed(int speed)
        //{
        //    _broadcaster.SendCurrentSpeed(speed);
        //}
    }
}