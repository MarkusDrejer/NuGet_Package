using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class BaseEvent
    {
        [Key]
        private int _id;
        private int _clientId;
        private string _eventType;
        private string _title;
        private string _data;
        private Level _level;

        public int Id
        {
            get => _id;
        }

        public int ClientId
        {
            get => _clientId;
            set
            {
                _clientId = value;
            }
        }

        public string EventType
        {
            get => _eventType;
            set
            {
                _eventType = value;
            }
        }

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
            }
        }

        public string Data
        {
            get => JsonConvert.SerializeObject(_data);
            set
            {
                _data = value;
            }
        }

        public Level Level
        {
            get => _level;
            set
            {
                _level = value;
            }
        }

        public virtual string GetData()
        {
            return Data;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
