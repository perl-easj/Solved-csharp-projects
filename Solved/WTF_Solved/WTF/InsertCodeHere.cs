using System;

namespace WTF
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            MysticNumbers numbers = new MysticNumbers();

            Console.WriteLine("{0}, expected 8", numbers.TwoNumbers(4,8));
            Console.WriteLine("{0}, expected 15", numbers.ThreeNumbers(2,15,9));
            Console.WriteLine("{0}, expected 14", numbers.FourNumbers(14,9,4,8));

            // The LAST line of code should be ABOVE this line
        }
    }
}