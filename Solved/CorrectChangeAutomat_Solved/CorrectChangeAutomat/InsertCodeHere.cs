using System;
using System.Collections.Generic;

namespace CorrectChangeAutomat
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            int originalAmountToPayBack = 234;

            // Løsning 1
            int amountToPayBack = originalAmountToPayBack;

            while (amountToPayBack >= 100)
            {
                Console.WriteLine("Her er en 100-kr seddel");
                amountToPayBack = amountToPayBack - 100;
            }

            while (amountToPayBack >= 10)
            {
                Console.WriteLine("Her er en 10-kr mønt");
                amountToPayBack = amountToPayBack - 10;
            }

            while (amountToPayBack >= 1)
            {
                Console.WriteLine("Her er en 1-kr mønt");
                amountToPayBack = amountToPayBack - 1;
            }

            Console.WriteLine();
            Console.WriteLine();

            // Løsning 2
            amountToPayBack = originalAmountToPayBack;
            int noOf100 = HowManyUnitsBack(amountToPayBack, 100);
            amountToPayBack = amountToPayBack - noOf100 * 100;
            int noOf10 = HowManyUnitsBack(amountToPayBack, 10);
            amountToPayBack = amountToPayBack - noOf10 * 10;

            Console.WriteLine($"100-kr sedler: {noOf100} 10-kr mønter: {noOf10} 1-kr mønter: {amountToPayBack}");

            // The LAST line of code should be ABOVE this line

        }

        public int HowManyUnitsBack(int amount, int unit)
        {
            return amount / unit;
        }
    }
}