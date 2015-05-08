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


        public void DoorLockCmd(CarSimulator clientModel)
        {
            
        }
    }
}