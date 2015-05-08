using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace RedTeam.Hubs
{
    public class DashboardHub : Hub
    {

        public void send(bool boxstatusLock)
        {
            Clients.All.doorlockCommand(boxstatusLock);


        }

    }
}