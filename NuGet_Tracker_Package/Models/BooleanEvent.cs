namespace Models
{
    public class BooleanEvent : BaseEvent
    {
        private bool _success;

        public bool Success
        {
            get => _success;
            set
            {
                Data += value;
            }
        }

        public override string GetData()
        {
            return Success.ToString();
        }

    }
}