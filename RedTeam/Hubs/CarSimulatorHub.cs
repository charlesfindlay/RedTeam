﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace RedTeam.Hubs
{
    public class CarSimulatorHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}