namespace OOP.Reflection.InfernoInfinity.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using OOP.Reflection.InfernoInfinity.Contracts;
    using OOP.Reflection.InfernoInfinity.Enums;

    public class WeaponFactory : IWeaponFactory
    {
        public IWeapon CreateWeapon(string weaponType, string name, Rarity rarity)
        {
            var weapon = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(x => x.Name.ToLower() == weaponType.ToLower());

            if (weapon == null)
            {
                throw new InvalidOperationException("Invalid weapon!");
            }

            var weaponInstance = (IWeapon)Activator.CreateInstance(weapon, new object[] { name, rarity });

            return weaponInstance;
        }
    }
}
