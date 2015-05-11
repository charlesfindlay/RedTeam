﻿using System;
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

        public void carLights(bool off)
        {
            Clients.All.carLights(off);
        }
    }
    
    
}