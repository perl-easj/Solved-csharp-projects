namespace ClockV10
{
    public class Clock
    {
        private int _minutes;
        private int _hours;

        public Clock(int hours, int minutes)
        {
            _minutes = minutes;
            _hours = hours;
        }

        public int Minutes
        {
            get { return _minutes; }
            set { _minutes = value; }
        }

        public int Hours
        {
            get { return _hours; }
            set { _hours = value; }
        }

        public void AdvanceOneMinute()
        {
            _minutes = (_minutes + 1) % 60;
            _hours = (_hours + (60 - _minutes) / 60) % 24;
        }

        public string Display
        {
            get
            {
                string displayString = string.Format("{0:00}:{1:00}", _hours, _minutes);
                return displayString;
            }
        }
    }
}