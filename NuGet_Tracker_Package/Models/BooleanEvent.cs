namespace Models
{
    public class BooleanEvent : BaseEvent
    {
        private bool _success;
        public bool Success { 
            get { return _success; } 
            set {
                Data.Add("success", value.ToString());
            }
        }

    }
}