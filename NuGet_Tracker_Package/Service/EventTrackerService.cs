using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Models;
using Newtonsoft.Json;
using NuGet_Tracker_Package.Configuration;

namespace NuGet_Tracker_Package.Service
{
    public class EventTrackerService : IEventTrackerService
    {
        private readonly EventTrackerConfiguration _config;
        private readonly ILogger _logger;

        public EventTrackerService(IOptions<EventTrackerConfiguration> configuration, ILogger logger)
        {
            _config = configuration.Value;
            _logger = logger;
        }

        public async Task TrackEvent(BaseEvent baseEvent)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(_config.ConnectionString);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                httpWebRequest.Headers.Add("x-api-key", _config.ApiKey);
                httpWebRequest.Headers.Add("guid", _config.ClientId.ToString());
                httpWebRequest.Headers.Add("event-type", baseEvent.GetType().Name);
                baseEvent.Data = baseEvent.GetData();
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(baseEvent, Formatting.Indented);
                    streamWriter.Write(json);
                }
                httpWebRequest.Proxy = null;
                await httpWebRequest.GetResponseAsync();
            } catch (Exception e)
            {
                _logger.LogError("Unable to track event ", e);
            }
        }
    }
}
