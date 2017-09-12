namespace CompanyV10
{
    public class Worker : Employee
    {
        #region Instance fields
        private int _hoursPerMonth;
        private int _salaryPerHour;
        #endregion

        #region Constructor
        public Worker(string name, int hoursPerMonth, int salaryPerHour) : base(name)
        {
            _hoursPerMonth = hoursPerMonth;
            _salaryPerHour = salaryPerHour;
        }
        #endregion

        #region Worker-specific properties
        public int HoursPerMonth
        {
            get { return _hoursPerMonth; }
        }

        public int SalaryPerHour
        {
            get { return _salaryPerHour; }
        }
        #endregion

        #region Property overrides
        public override int SalaryPerMonth
        {
            get { return _hoursPerMonth * _salaryPerHour; }
        }

        public override int BonusPerMonth
        {
            get { return 0; }
        }

        public override bool PayoutBonus
        {
            get { return false; }
        } 
        #endregion
    }
}
