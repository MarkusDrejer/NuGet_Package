using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Models
{
    public class BaseEvent
    {
        [Key]
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string EventType { get; set; }
        public string Title { get; set; }
        public Dictionary<string, string> DataHolder { get; }
        public string Data { get { return JsonConvert.SerializeObject(DataHolder); } set { } }
        public Level Level { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

        public BaseEvent()
        {
            DataHolder = new Dictionary<string, string>();
        }
    }
}
