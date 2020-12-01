using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NuGet_Tracker_Package.Models
{
    public class HeartbeatEvent : BaseEvent
    {
        public HeartbeatEvent(string title)
        {
            Data = "Heartbeat";
            Title = title;
            Level = Level.HEARTBEAT;
        }

        public HeartbeatEvent UpdatedHeartbeat()
        {
            Timestamp = DateTime.UtcNow;
            return this;
        }
    }
}
