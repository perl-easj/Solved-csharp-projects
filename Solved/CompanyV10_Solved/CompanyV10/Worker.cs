namespace CompanyV10
{
    public class Worker : Employee
    {
        private int _hoursPerMonth;
        private int _salaryPerHour;

        public Worker(string name, int hoursPerMonth, int salaryPerHour) : base(name)
        {
            _hoursPerMonth = hoursPerMonth;
            _salaryPerHour = salaryPerHour;
        }

        public override int SalaryPerMonth
        {
            get { return _hoursPerMonth * _salaryPerHour ; }
        }

        public override int BonusPerMonth
        {
            get { return 0; }
        }

        public override bool PayoutBonus
        {
            get { return false; }
        }

        public int HoursPerMonth
        {
            get { return _hoursPerMonth; }
        }

        public int SalaryPerHour
        {
            get { return _salaryPerHour; }
        }
    }
}
