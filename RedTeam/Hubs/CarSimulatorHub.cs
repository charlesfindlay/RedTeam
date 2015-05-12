using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace RedTeam.Hubs
{
    public class CarSimulatorHub : Hub
    {
        public CarSimulatorHub() : this(Broadcaster.Instance) { }

        public CarSimulatorHub(Broadcaster broadcaster)
        {
            _broadcaster = broadcaster;
        }
        private Broadcaster _broadcaster;




        public void doorLock(bool locked)
        {
            Clients.All.doorLock(locked);
        }

        public void trunkOpen(bool open)
        {
            Clients.All.trunkOpen(open);
        }
        
        public void carLight(bool off)
        {
            Clients.All.carLight(off);
        }

        public void carEngine(bool off)
        {
            Clients.All.carEngine(off);
        }

        public void SendSpeed(int speed)
        {

            _broadcaster.SendCurrentSpeed(speed);
        }

        public void SendGas(int gas)
        {

            _broadcaster.SendCurrentGasLevel(gas);
        }
    }
    
    
}