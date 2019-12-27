namespace OOP.Reflection.InfernoInfinity.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using OOP.Reflection.InfernoInfinity.Contracts;

    public class WeaponRepository : IWeaponRepository
    {
        private ICollection<IWeapon> weapons;

        public WeaponRepository()
        {
            this.weapons = new List<IWeapon>();
        }

        public void AddWeapon(IWeapon weapon)
        {
            if (this.weapons.Any(x => x.Name.ToLower() == weapon.Name.ToLower()))
            {
                throw new ArgumentException($"{weapon.GetType().Name} with name {weapon.Name} already exist!");
            }

            this.weapons.Add(weapon);
        }

        public void AddGemToWeapon(string weaponName, int gemIndex, IGem gem)
        {
            if (!this.weapons.Any(x => x.Name == weaponName))
            {
                throw new ArgumentException($"{weaponName} doesn't exist");
            }

            var currentWeapon = this.weapons.FirstOrDefault(x => x.Name.ToLower() == weaponName.ToLower());

            if (gemIndex > currentWeapon.Sockets - 1)
            {
                throw new ArgumentException("Invalid socket");
            }

            currentWeapon.AddGem(gemIndex, gem);
        }

        public void RemoveGemFromWeapon(string weaponName, int gemIndex)
        {
            var currentWeapon = this.weapons.FirstOrDefault(x => x.Name.ToLower() == weaponName.ToLower());

            if (currentWeapon == null)
            {
                throw new ArgumentException($"{weaponName} doesn't exist");
            }

            currentWeapon.RemoveGem(gemIndex);
        }

        public string PrintWeapon(string weaponName)
        {
            var currentWeapon = this.weapons.FirstOrDefault(x => x.Name.ToLower() == weaponName.ToLower());

            if (currentWeapon == null)
            {
                return $"{weaponName} doesn't exist";
            }

            return currentWeapon.ToString();
        }

        public string PrintAllWeapons()
        {
            var sb = new StringBuilder();

            foreach (var weapon in this.weapons)
            {
                sb.AppendLine(weapon.ToString());
            }

            return sb.ToString();
        }
    }
}
