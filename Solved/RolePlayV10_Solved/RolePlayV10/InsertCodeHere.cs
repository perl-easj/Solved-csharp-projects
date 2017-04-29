using System;

namespace RolePlayV10
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Warrior theWarrior = new Warrior("Ragnar", 200);

            Console.WriteLine("{0} is level {1}, and has {2} hit points. Dead = {3}",theWarrior.Name, theWarrior.Level,theWarrior.HitPoints,theWarrior.Dead);

            theWarrior.DecreaseHitPoints(65);
            Console.WriteLine("{0} is level {1}, and has {2} hit points. Dead = {3}", theWarrior.Name, theWarrior.Level, theWarrior.HitPoints, theWarrior.Dead);

            theWarrior.LevelUp();
            Console.WriteLine("{0} is level {1}, and has {2} hit points. Dead = {3}", theWarrior.Name, theWarrior.Level, theWarrior.HitPoints, theWarrior.Dead);

            theWarrior.DecreaseHitPoints(150);
            Console.WriteLine("{0} is level {1}, and has {2} hit points. Dead = {3}", theWarrior.Name, theWarrior.Level, theWarrior.HitPoints, theWarrior.Dead);


            // The LAST line of code should be ABOVE this line
        }
    }
}