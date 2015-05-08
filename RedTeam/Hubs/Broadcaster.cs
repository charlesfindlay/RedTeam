using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading;

namespace RedTeam.Hubs
{
     public class Broadcaster 
    { 
        private readonly static Lazy<Broadcaster> _instance = 
            new Lazy<Broadcaster>(() => new Broadcaster()); 
        // We're going to broadcast to all clients 50 times per second 
        private readonly TimeSpan BroadcastInterval = 
            TimeSpan.FromMilliseconds(40); 
        private readonly IHubContext _hubContext; 
        private Timer _broadcastLoop; 
        private CarSimulator _model; 
        private bool _modelUpdated; 
 
        public Broadcaster() 
        { 
            // Save our hub context so we can easily use it  
            // to send to its connected clients 
            _hubContext = GlobalHost.ConnectionManager.GetHubContext<MoveShapeHub>(); 
 
            _model = new ShapeModel(); 
            _modelUpdated = false; 
 
            // Start the broadcast loop 
            _broadcastLoop = new Timer( 
                BroadcastShape, 
                null, 
                BroadcastInterval, 
                BroadcastInterval); 
        }
}