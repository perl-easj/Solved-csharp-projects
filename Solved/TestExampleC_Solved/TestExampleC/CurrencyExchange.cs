using System;
using System.Collections.Generic;

namespace TestExampleC
{
    public class CurrencyExchange
    {
        private Dictionary<string, double> _exchangeRates;

        public CurrencyExchange()
        {
            _exchangeRates = new Dictionary<string, double>();
        }

        public void SetExchangeRate(string currencyCross, double exchangeRate)
        {
            if (!IsLegalCurrencyCross(currencyCross))
            {
                throw new ArgumentException(currencyCross + " is not a legal currency cross");
            }

            if (exchangeRate <= 0)
            {
                throw new ArgumentException(exchangeRate + " is not a legal exchange rate");
            }

            _exchangeRates[currencyCross] = exchangeRate;
        }

        public double DoExchange(string currencyCross, double amount)
        {
            if (!IsLegalCurrencyCross(currencyCross))
            {
                throw new ArgumentException(currencyCross + " is not a legal currency cross");
            }

            if (!_exchangeRates.ContainsKey(currencyCross))
            {
                throw new ArgumentException("Exchange rate has not been set for " + currencyCross);
            }

            if (amount <= 0)
            {
                throw new ArgumentException(amount + " is not a legal amount");
            }

            return _exchangeRates[currencyCross] * amount;
        }

        private bool IsLegalCurrencyCross(string currencyCross)
        {
            // A currency cross must
            // 1) Not be null, empty or only contains spaces
            // 2) Be exactly six characters long
            // 3) Be between two different currencies, i.e. USDUSD is not legal.
            //
            if (!string.IsNullOrWhiteSpace(currencyCross) && currencyCross.Length == 6)
            {
                return currencyCross.Substring(0,3) != currencyCross.Substring(3,3);
            }

            return false;
        }
    }
}