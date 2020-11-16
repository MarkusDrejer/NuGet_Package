using System.IO;
using System.Net;
using Models;
using Newtonsoft.Json;

namespace NuGet_Tracker_Package
{
    public class EventTracker
    {
        public static void TrackEvent(BaseEvent trigger, string apiKey)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:7071/api/Function1");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add("x-api-key", apiKey);
            httpWebRequest.Headers.Add("event-type", trigger.GetType().Name);

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(trigger, Formatting.Indented);
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
