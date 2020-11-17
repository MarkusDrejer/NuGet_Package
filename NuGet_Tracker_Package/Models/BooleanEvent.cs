namespace Models
{
    public class BooleanEvent : BaseEvent
    {
        public bool Success { get; set; }

        public override string GetData()
        {
            return Success.ToString();
        }
    }
}