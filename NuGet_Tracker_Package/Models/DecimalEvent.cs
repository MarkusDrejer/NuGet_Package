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
                DataHolder.Add("value", value.ToString());
            }
        }

    }
}