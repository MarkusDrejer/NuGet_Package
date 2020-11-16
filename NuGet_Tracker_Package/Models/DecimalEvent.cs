namespace Models
{
    public class DecimalEvent : BaseEvent
    {
        private decimal _value;
        public decimal Value
        {
            get { return _value; }
            set
            {
                Data.Add("value", value.ToString());
            }
        }

    }
}