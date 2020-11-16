namespace Models
{
    public class BooleanEvent : BaseEvent
    {
        private bool _success;
        public bool Success { 
            get { return _success; }
            set {
                DataHolder.Add("success", value.ToString());
            }
        }

    }
}