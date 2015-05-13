using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading;
using RedTeam.Models;
using System.Threading.Tasks;

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
 
         

         internal void SendLockCmd(bool myCarIsLocked)
         {
             _model.doorLock = myCarIsLocked;
             _simulatorhubContext.Clients.All.DoorLock(myCarIsLocked);
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
            var tempNow = _model.engineTemp;
            _simulatorhubContext.Clients.All.CarEngine(myCarEngineOff);
            CalculateEngineTemp(myCarEngineOff, tempNow);
            
        }

         internal void SendCurrentGasLevel(int gas)
         {
             _model.gasLevel = gas;
             _dashboardhubContext.Clients.All.SendAGasLevel(gas);
         }

         internal void UpdateEngineTemp(int tempNow)
         {
             _model.engineTemp = tempNow;
         }

         public async Task CalculateEngineTemp(bool myCarEngineOff, int tempNow)
         {
             if (myCarEngineOff == false)
             {
                 while (tempNow < 225)
                 {
                     tempNow += 15;
                     if (tempNow > 225) { tempNow = 225; }
                     await Task.Delay(1000);
                     _dashboardhubContext.Clients.All.DisplayEngineTemp(tempNow);
                 }
             }

             if (myCarEngineOff == true)
             {
                 while (tempNow > 0)
                 {
                     tempNow -= 15;
                     if (tempNow < 0) { tempNow = 0; }
                     await Task.Delay(1000);
                     _dashboardhubContext.Clients.All.DisplayEngineTemp(tempNow);
                 }
             }
         }

    }
}
