using System;

namespace RolePlayV15
{
    /// <summary>
    /// This class represents a warrior character in the game.
    /// </summary>
    class Warrior
    {
        private int _hitPoints;
        private int _initialHitPoints;
        private int _level;

        private Weapon _weapon1;
        private Weapon _weapon2;
        private Weapon _weapon3;

        /// <summary>
        /// Creates a Warrior object, with the specified number of hit points
        /// </summary>
        public Warrior(int initialHitPoints)
        {
            _level = 0;
            _initialHitPoints = initialHitPoints;
            _hitPoints = _initialHitPoints;

            _weapon1 = null;
            _weapon2 = null;
            _weapon3 = null;
        }

        /// <summary>
        /// The current number of hit points for the character
        /// </summary>
        public int HitPoints
        {
            get { return _hitPoints; }
        }

        /// <summary>
        /// The current level of the character
        /// </summary>
        public int Level
        {
            get { return _level; }
        }

        /// <summary>
        /// Returns true if the character is dead (i.e. hit points is below zero)
        /// </summary>
        public bool Dead
        {
            get { return _hitPoints < 0; }
        }

        /// <summary>
        /// Resets the hit points to the initial value
        /// </summary>
        public void Heal()
        {
            _hitPoints = _initialHitPoints;
        }

        /// <summary>
        /// Called when the character takes damage. The amount of damage (in hit points)
        /// is specified as a parameter 
        /// </summary>
        public void TakeDamage(int damagePoints)
        {
            if (_hitPoints >= 0)
            {
                _hitPoints = _hitPoints - damagePoints;
            }
        }

        /// <summary>
        /// Called when the character should ascend to the next level
        /// </summary>
        public void AscendToNextLevel()
        {
            _level++;
        }

        /// <summary>
        /// Tries to add a weapon to the character's set of weapons.
        /// The weapon can only be added if one of the three
        /// weapons slots is free
        /// </summary>
        public bool AddWeapon(Weapon aWeapon)
        {
            if (_weapon1 == null)
            {
                _weapon1 = aWeapon;
                return true;
            }
            else if (_weapon2 == null)
            {
                _weapon2 = aWeapon;
                return true;
            }
            else if (_weapon3 == null)
            {
                _weapon3 = aWeapon;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// This code is a bit clumsy, don't you think...?
        /// </summary>
        public int UseWeapon(string weaponName)
        {
            if (_weapon1 != null)
            {
                if (_weapon1.Name == weaponName)
                {
                    return _weapon1.Damage();
                }
            }

            if (_weapon2 != null)
            {
                if (_weapon2.Name == weaponName)
                {
                    return _weapon2.Damage();
                }
            }

            if (_weapon3 != null)
            {
                if (_weapon3.Name == weaponName)
                {
                    return _weapon3.Damage();
                }
            }

            return 0; // if all of the above fails
        }
    }
}
