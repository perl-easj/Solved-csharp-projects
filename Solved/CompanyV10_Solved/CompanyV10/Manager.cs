namespace CompanyV10
{
    public abstract class Manager : Employee
    {
        private int _baseSalary;
        private int _bonusSalary;
        protected Manager(string name, int baseSalary, int bonusSalary) : base(name)
        {
            _baseSalary = baseSalary;
            _bonusSalary = bonusSalary;
        }

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
    }
}
