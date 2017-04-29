namespace CompanyV10
{
    class JuniorManager : Manager
    {
        private int _hoursWorkedThisMonth;
        private const int MinimumHoursWorkedForBonus = 180;

        public JuniorManager(string name, int baseSalary, int bonusSalary) 
            : base(name, baseSalary, bonusSalary)
        {
        }

        public override bool PayoutBonus
        {
            get { return _hoursWorkedThisMonth >= MinimumHoursWorkedForBonus; }
        }

        public int HoursWorkedThisMonth
        {
            get { return _hoursWorkedThisMonth; }
            set { _hoursWorkedThisMonth = value; }
        }
    }
}
