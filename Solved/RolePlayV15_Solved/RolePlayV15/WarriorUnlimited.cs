using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayV15
{
    class WarriorUnlimited
    {
        private int _hitPoints;
        private int _initialHitPoints;
        private int _level;

        private List<Weapon> _weapons;

        /// <summary>
        /// Creates a WarriorUnlimited object, with the specified number of hit points
        /// </summary>
        public WarriorUnlimited(int initialHitPoints)
        {
            _level = 0;
            _initialHitPoints = initialHitPoints;
            _hitPoints = _initialHitPoints;

            _weapons = new List<Weapon>();
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
        /// Add a weapon to the character's set of weapons.
        /// </summary>
        public void AddWeapon(Weapon aWeapon)
        {
            _weapons.Add(aWeapon);
        }

        /// <summary>
        /// This code is much better, don't you think...?
        /// </summary>
        public int UseWeapon(string weaponName)
        {
            foreach (var weapon in _weapons)
            {
                if (weapon.Name == weaponName)
                {
                    return weapon.Damage();
                }
            }

            return 0; // if no matching weapon was found
        }
    }
}
