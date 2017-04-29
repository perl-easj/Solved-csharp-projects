using System;
using System.Collections.Generic;

namespace RolePlayV15
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Weapon weapon1 = new Weapon("Sting", 20, 40);
            Weapon weapon2 = new Weapon("DoomBringer", 50, 150);
            Weapon weapon3 = new Weapon("BFG", 500, 1000);

            Console.WriteLine("{0} dealt {1} damage", weapon1.Name, weapon1.Damage());
            Console.WriteLine("{0} dealt {1} damage", weapon1.Name, weapon1.Damage());

            Console.WriteLine("{0} dealt {1} damage", weapon2.Name, weapon2.Damage());
            Console.WriteLine("{0} dealt {1} damage", weapon2.Name, weapon2.Damage());

            Console.WriteLine("{0} dealt {1} damage", weapon3.Name, weapon3.Damage());
            Console.WriteLine("{0} dealt {1} damage", weapon3.Name, weapon3.Damage());


            Warrior theWarrior = new Warrior(500);
            theWarrior.AddWeapon(weapon1);
            theWarrior.AddWeapon(weapon2);
            theWarrior.AddWeapon(weapon3);

            string weaponName = "DoomBringer";
            Console.WriteLine("The warrior dealt {0} damage using {1}",theWarrior.UseWeapon(weaponName), weaponName);

            weaponName = "Stinger";
            Console.WriteLine("The warrior dealt {0} damage using {1}", theWarrior.UseWeapon(weaponName), weaponName);

            weaponName = "Sting";
            Console.WriteLine("The warrior dealt {0} damage using {1}", theWarrior.UseWeapon(weaponName), weaponName);

            weaponName = "bfg";
            Console.WriteLine("The warrior dealt {0} damage using {1}", theWarrior.UseWeapon(weaponName), weaponName);

            weaponName = "BFG";
            Console.WriteLine("The warrior dealt {0} damage using {1}", theWarrior.UseWeapon(weaponName), weaponName);


            WarriorUnlimited theNextWarrior = new WarriorUnlimited(500);
            theNextWarrior.AddWeapon(weapon1);
            theNextWarrior.AddWeapon(weapon2);
            theNextWarrior.AddWeapon(weapon3);
            theNextWarrior.AddWeapon(new Weapon("SlingShot", 2, 10));
            theNextWarrior.AddWeapon(new Weapon("NuclearGrenade", 2000, 10000));

            List<string> tryAllTheseWeapons = new List<string> {"DoomBringer","Stinger","Sting","bfg", "BFG", "SlingShot","NuclearGrenade"};

            foreach (string name in tryAllTheseWeapons)
            {
                Console.WriteLine("The (unlimited) warrior dealt {0} damage using {1}", theNextWarrior.UseWeapon(name), name);
            }

            // The LAST line of code should be ABOVE this line
        }
    }
}