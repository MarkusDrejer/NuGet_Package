using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class BaseEvent
    {
        [Key]
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string EventType { get; set; }
        public string Title { get; set; }

        private Dictionary<string, string> _data;
        public Dictionary<string, string> Data { get { return _data; } }
        public Level Level { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

        public BaseEvent()
        {
            _data = new Dictionary<string, string>();
        }
    }
}
