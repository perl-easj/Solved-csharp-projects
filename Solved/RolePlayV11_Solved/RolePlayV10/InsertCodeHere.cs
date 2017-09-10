using System;

namespace RolePlayV11
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Warrior firstWarrior = new Warrior("Ragnar", 200);
            Warrior secondWarrior = new Warrior("Lagertha", 240);

            Console.WriteLine($"{firstWarrior.Name} is level {firstWarrior.Level}, has {firstWarrior.HitPoints} hit points, Dead : {firstWarrior.Dead}");
            Console.WriteLine($"{secondWarrior.Name} is level {secondWarrior.Level}, has {secondWarrior.HitPoints} hit points, Dead : {secondWarrior.Dead}");

            firstWarrior.DecreaseHitPoints(180);
            secondWarrior.DecreaseHitPoints(180);

            Console.WriteLine($"{firstWarrior.Name} is level {firstWarrior.Level}, has {firstWarrior.HitPoints} hit points, Dead : {firstWarrior.Dead}");
            Console.WriteLine($"{secondWarrior.Name} is level {secondWarrior.Level}, has {secondWarrior.HitPoints} hit points, Dead : {secondWarrior.Dead}");

            firstWarrior.DecreaseHitPoints(50);
            secondWarrior.DecreaseHitPoints(50);

            Console.WriteLine($"{firstWarrior.Name} is level {firstWarrior.Level}, has {firstWarrior.HitPoints} hit points, Dead : {firstWarrior.Dead}");
            Console.WriteLine($"{secondWarrior.Name} is level {secondWarrior.Level}, has {secondWarrior.HitPoints} hit points, Dead : {secondWarrior.Dead}");

            // The LAST line of code should be ABOVE this line
        }
    }
}