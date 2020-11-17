using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class BaseEvent
    {
        [Key]
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string EventType { get; set; }
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
    }
}
