namespace CompanyV10
{
    class SeniorManager : Manager
    {
        private int _performanceRatingThisMonth;
        private const int MinimumRatingForBonus = 6;

        public SeniorManager(string name, int baseSalary, int bonusSalary) : 
            base(name, baseSalary, bonusSalary)
        {
        }

        public override bool PayoutBonus
        {
            get { return _performanceRatingThisMonth >= MinimumRatingForBonus; }
        }

        public int PerformanceRatingThisMonth
        {
            get { return _performanceRatingThisMonth; }
            set { _performanceRatingThisMonth = value; }
        }
    }
}
