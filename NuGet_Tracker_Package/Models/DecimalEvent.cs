namespace Models
{
    public class DecimalEvent : BaseEvent
    {
        private decimal _value;

        public decimal Value
        {
            get => _value;
            set
            {
                Data += $" [Value: {value}] ";
            }
        }

        public override string GetData()
        {
            return $"{Value}";
        }
    }
}