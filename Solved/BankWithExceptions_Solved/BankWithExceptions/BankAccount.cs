namespace BankWithExceptions
{
    class BankAccount
    {
        private double _balance;
        private double _interestRate;

        /// <summary>
        /// Balance of the account; must not become negative
        /// </summary>
        public double Balance
        {
            get { return _balance; }
        }

        /// <summary>
        /// Interest rate of the account; must be between 0.0 and 20.0
        /// </summary>
        public double InterestRate
        {
            get { return _interestRate; }
        }


        public BankAccount(double interestRate)
        {
            if (interestRate < 0.0 || interestRate > 20.0)
            {
                IllegalInterestRateException e = new IllegalInterestRateException();
                throw e;
            }

            _interestRate = interestRate;
            _balance = 0.0;
        }

        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                NegativeAmountException e = new NegativeAmountException();
                throw e;
            }

            _balance = _balance + amount;
        }

        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                NegativeAmountException e = new NegativeAmountException();
                throw e;
            }

            if (_balance < amount)
            {
                throw new WithdrawAmountTooLargeException();
            }

            _balance = _balance - amount;
        }
    }
}
