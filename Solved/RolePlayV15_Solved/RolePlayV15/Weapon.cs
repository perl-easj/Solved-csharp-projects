using System;

namespace RolePlayV15
{
    /// <summary>
    /// This class is supposed to represent a weapon in the game.
    /// </summary>
    class Weapon
    {
        private string _name;
        private int _minDamage;
        private int _maxDamage;

        public string Name { get { return _name; } }
        public int MinDamage { get { return _minDamage; } }
        public int MaxDamage { get { return _maxDamage; } }

        public Weapon(string name, int minDamage, int maxDamage)
        {
            _name = name;
            _minDamage = minDamage;
            _maxDamage = maxDamage;
        }

        public int Damage()
        {
            return RandomNumberGenerator.RandomNumber(_minDamage, _maxDamage);
        }
    }
}
