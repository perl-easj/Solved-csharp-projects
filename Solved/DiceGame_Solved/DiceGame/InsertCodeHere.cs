using System;

namespace DiceGame
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            DiceCup cup = new DiceCup();
            Console.WriteLine("Total value is {0}", cup.TotalValue);

            cup.Shake();
            Console.WriteLine("Total value is {0}", cup.TotalValue);

            DieNSides d100 = new DieNSides(100);
            d100.Roll();
            Console.WriteLine("100-sided die shows {0}", d100.Value);

            // The LAST line of code should be ABOVE this line
        }
    }
}