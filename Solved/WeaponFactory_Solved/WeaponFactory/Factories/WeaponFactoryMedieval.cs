using System;
using WeaponFactory.Interfaces;
using WeaponFactory.Weapons;

namespace WeaponFactory.Factories
{
    /// <summary>
    /// Weapon factory class for medieval weapons.
    /// </summary>
    public class WeaponFactoryMedieval : IWeaponFactory
    {
        public IWeapon Create(WeaponType type)
        {
            switch (type)
            {
                case WeaponType.Meele:
                    return new Dagger();
                case WeaponType.Ranged:
                    return new CrossBow();
                case WeaponType.Magic:
                    return new Wand();
                default:
                    throw new ArgumentException($"WeaponFactoryMedieval - no class available for weapon type {type}");
            }
        }
    }
}