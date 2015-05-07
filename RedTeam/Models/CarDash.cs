using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedTeam.Models
{
    public class CarDash
    {
        public int Id { get; set; }
        public bool HeadLightStatus { get; set; }
        public bool DoorLockStatus { get; set; }
        public bool HornStatus { get; set; }
    }
}