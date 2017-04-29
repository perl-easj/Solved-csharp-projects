using System;

namespace RolePlayV20
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            NumberGenerator theNumberGenerator = new NumberGenerator();
            BattleLog theLog = new BattleLog();

            Hero theHero = new Hero(theNumberGenerator, theLog, 100, 10, 30);
            Beast theBeast = new Beast(theNumberGenerator, theLog, 90, 10, 25);

            // Så længe begge deltagere er i live
            while (!theHero.Dead && !theBeast.Dead)
            {
                // Den ene slår den anden
                int damageByHero = theHero.DealDamage();
                theBeast.ReceiveDamage(damageByHero);

                // Den anden slås den første, hvis den anden ikke er død i mellemtiden
                if (!theBeast.Dead)
                {
                    int damageByBeast = theBeast.DealDamage();
                    theHero.ReceiveDamage(damageByBeast);
                }
            }

            theLog.PrintLog();

            // The LAST line of code should be ABOVE this line
        }
    }
}