using System;

namespace RolePlayV10
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Warrior theWarrior = new Warrior("Ragnar");

            Console.WriteLine($"{theWarrior.Name} is level {theWarrior.Level}");

            theWarrior.LevelUp();
            Console.WriteLine($"{theWarrior.Name} is level {theWarrior.Level}");

            theWarrior.LevelUp();
            theWarrior.LevelUp();
            theWarrior.LevelUp();
            Console.WriteLine($"{theWarrior.Name} is level {theWarrior.Level}");

            // The LAST line of code should be ABOVE this line
        }
    }
}