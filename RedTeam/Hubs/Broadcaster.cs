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
        // We're going to broadcast to all clients 50 times per second 
        private readonly TimeSpan BroadcastInterval =
            TimeSpan.FromMilliseconds(40);
        private readonly IHubContext _simulatorhubContext;
        private readonly IHubContext _dashboardhubContext;
        private Timer _broadcastLoop;
        private CarSimulator _model;
        private bool _modelUpdated;

        public Broadcaster()
        {
            // Save our hub context so we can easily use it  
            // to send to its connected clients 
            _simulatorhubContext = GlobalHost.ConnectionManager.GetHubContext<CarSimulatorHub>();
            _dashboardhubContext = GlobalHost.ConnectionManager.GetHubContext<DashboardHub>();

            _model = new CarSimulator();
            _modelUpdated = false;

            // Start the broadcast loop 
            _broadcastLoop = new Timer(
                CheckCarStatus,
                null,
                BroadcastInterval,
                BroadcastInterval);

            public static Broadcaster Instance 
            { 
                get 
                { 
                    return _instance.Value; 
                } 
            }
 
         public void CheckCarState(object state) 
        { 
            // No need to send anything if our model hasn't changed 
            if (_modelUpdated) 
            { 
                // This is how we can access the Clients property  
                // in a static hub method or outside of the hub entirely 
                _hubContext.Clients.AllExcept(_model.LastUpdatedBy).updateShape(_model); 
                _modelUpdated = false; 
            } 
        }
    }
}
