namespace Models
{
    public class DecimalEvent : BaseEvent
    {
        public decimal Value { get; set; }

        public override string GetData()
        {
            return Value.ToString();
        }
    }
}