using System;
using System.ComponentModel;

namespace Models
{
    public class BaseEvent
    {

        public string Title { get; set; }

        public DateTime Timestamp { get; set; }

        public string Data { get; set; }

        public Level Level { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

        public virtual string GetData()
        {
            return Data;
        }

        public BaseEvent()
        {
            Timestamp = DateTime.UtcNow;
        }
    }
}
