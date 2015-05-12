using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading;
using RedTeam.Models;

namespace RedTeam.Hubs
{
    public class Broadcaster
    {
        private readonly static Lazy<Broadcaster> _instance =
            new Lazy<Broadcaster>(() => new Broadcaster());
        private readonly IHubContext _simulatorhubContext;
        private readonly IHubContext _dashboardhubContext;
        private CarSimulator _model;

        public Broadcaster()
        {
            // Save our hub context so we can easily use it  
            // to send to its connected clients 
            _simulatorhubContext = GlobalHost.ConnectionManager.GetHubContext<CarSimulatorHub>();
            _dashboardhubContext = GlobalHost.ConnectionManager.GetHubContext<DashboardHub>();

            _model = new CarSimulator();

           
        }

            public static Broadcaster Instance 
            { 
                get 
                { 
                    return _instance.Value; 
                } 
            }
 
         internal void SendCurrentSpeed(int speed1)
         {
             _model.speed = speed1;
             _dashboardhubContext.Clients.All.SendASpeed(speed1);
         }
         internal CarSimulator GetCarModel()
         {
             return _model;
         }
         
        internal void SendLightCmd(bool myCarLightOff)
         {
             _model.carLight = myCarLightOff;
             _simulatorhubContext.Clients.All.CarLights(myCarLightOff);
         }

        internal void SendEngineCmd(bool myCarEngineOff)
        {
            _model.carEngine = myCarEngineOff;
            _simulatorhubContext.Clients.All.CarEngine(myCarEngineOff);
        }

         internal void SendCurrentGasLevel(int gas)
         {
             _model.gasLevel = gas;
             _dashboardhubContext.Clients.All.SendAGasLevel(gas);    
         }

         internal void SendLockCmd(bool myCarIsLocked)
         {
             _model.doorLock = myCarIsLocked;
             _simulatorhubContext.Clients.All.DoorLock(myCarIsLocked);
         }
    }
}
