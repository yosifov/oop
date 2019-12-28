namespace OOP.Reflection.InfernoInfinity.Models.Commands
{
    using System;
    using OOP.Reflection.InfernoInfinity.Contracts;
    using OOP.Reflection.InfernoInfinity.Enums;

    public class CreateCommand : IExecutable
    {
        private readonly IWeaponFactory weaponFactory;
        private readonly IWeaponRepository weapons;

        public CreateCommand(IWeaponFactory weaponFactory, IWeaponRepository weapons)
        {
            this.weaponFactory = weaponFactory;
            this.weapons = weapons;
        }

        public string Execute(string[] data)
        {
            if (data.Length != 2)
            {
                return $"Invalid command arguments";
            }

            try
            {
                var weaponTypeArgs = data[0].Split();
                Rarity weaponRarity = (Rarity)Enum.Parse(typeof(Rarity), weaponTypeArgs[0]);
                string weaponType = weaponTypeArgs[1];
                
                var weaponName = data[1];
                
                var currentWeapon = this.weaponFactory.CreateWeapon(weaponType, weaponName, weaponRarity);
                this.weapons.AddWeapon(currentWeapon);

                return $"{weaponName} successfuly created!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
