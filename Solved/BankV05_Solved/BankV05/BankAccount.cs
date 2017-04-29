namespace BankV05
{
    public class BankAccount
    {
        private double _balance;
        private string _name;

        public double Balance
        {
            get { return _balance;}
        }

        public string Name
        {
            get { return _name; }
        }

        public BankAccount(string name)
        {
            _balance = 0.0;
            _name = name;
        }

        public void Deposit(double amount)
        {
            _balance = _balance + amount;
        }

        public void Withdraw(double amount)
        {
            _balance = _balance - amount;
        }
    }
}