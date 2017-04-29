using System;

namespace ClockV10
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Clock myClock = new Clock(13,59);

            Console.WriteLine(myClock.Display);
            myClock.AdvanceOneMinute();
            Console.WriteLine(myClock.Display);
            myClock.AdvanceOneMinute();
            Console.WriteLine(myClock.Display);

            myClock.Hours = 23;
            myClock.Minutes = 59;

            Console.WriteLine(myClock.Display);
            myClock.AdvanceOneMinute();
            Console.WriteLine(myClock.Display);
            myClock.AdvanceOneMinute();
            Console.WriteLine(myClock.Display);

            // The LAST line of code should be ABOVE this line
        }
    }
}