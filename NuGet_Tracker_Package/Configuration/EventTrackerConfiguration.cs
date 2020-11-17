using System;

namespace NuGet_Tracker_Package.Configuration
{
    public class EventTrackerConfiguration
    {
        public Guid ClientId { get; set; }
        public string ConnectionString { get; set; }
        public string ApiKey { get; set; }
    }
}
