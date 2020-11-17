using System.IO;
using System.Net;
using Microsoft.Extensions.Options;
using Models;
using Newtonsoft.Json;
using NuGet_Tracker_Package.Configuration;

namespace NuGet_Tracker_Package.Service
{
    public class EventTrackerService : IEventTrackerService
    {
        private readonly EventTrackerConfiguration _config;

        public EventTrackerService(IOptions<EventTrackerConfiguration> configuration)
        {
            _config = configuration.Value;
        }

        public void TrackEvent(BaseEvent baseEvent)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:7071/api/Function1");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add("x-api-key", _config.ApiKey);
            //httpWebRequest.Headers.Add("event-type", baseEvent.GetType().Name);
            baseEvent.Data = baseEvent.GetData();
            baseEvent.Guid = _config.ClientId;  
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(baseEvent, Formatting.Indented);
                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }
    }
}
