using System;
using WeaponFactory.Interfaces;
using WeaponFactory.Weapons;

namespace WeaponFactory.Factories
{
    /// <summary>
    /// Weapon factory class for futuristic weapons.
    /// </summary>
    public class WeaponFactoryFuture : IWeaponFactory
    {
        public IWeapon Create(WeaponType type)
        {
            switch (type)
            {
                case WeaponType.Meele:
                    return new TazerKnuckles();
                case WeaponType.Ranged:
                    return new Phaser();
                case WeaponType.Magic:
                    return new VacuumEnergyChanneler();
                default:
                    throw new ArgumentException($"WeaponFactoryFuture - no class available for weapon type {type}");
            }
        }
    }
}