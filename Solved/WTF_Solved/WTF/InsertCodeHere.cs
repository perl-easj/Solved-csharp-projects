using System;

namespace WTF
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            MysticNumbers numbers = new MysticNumbers();

            Console.WriteLine($"{numbers.TwoNumbers(4,8)}, expected 8");
            Console.WriteLine($"{numbers.ThreeNumbers(2,15,9)}, expected 15");
            Console.WriteLine($"{numbers.FourNumbers(14,9,4,8)}, expected 14");

            // The LAST line of code should be ABOVE this line
        }
    }
}