namespace CompanyV10
{
    /// <summary>
    /// This class inherits from Employee, but
    /// also acts as a base class.
    /// </summary>
    public abstract class Manager : Employee
    {
        #region Instance fields
        private int _baseSalary;
        private int _bonusSalary;
        #endregion

        #region Constructor
        protected Manager(string name, int baseSalary, int bonusSalary) : base(name)
        {
            _baseSalary = baseSalary;
            _bonusSalary = bonusSalary;
        }
        #endregion

        #region Property overrides
        public override int SalaryPerMonth
        {
            get
            {
                int totalSalary = _baseSalary + (PayoutBonus ? BonusPerMonth : 0);
                return totalSalary;
            }
        }

        public override int BonusPerMonth
        {
            get { return _bonusSalary; }
        } 
        #endregion
    }
}
