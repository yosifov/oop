namespace OOP.Reflection.InfernoInfinity.Models.Commands
{
    using System;
    using OOP.Reflection.InfernoInfinity.Contracts;
    using OOP.Reflection.InfernoInfinity.Enums;

    public class CreateCommand : Command
    {
        public CreateCommand(string[] data, IWeaponFactory weaponFactory, IGemFactory gemFactory, IWeaponRepository weapons)
            : base(data, weaponFactory, gemFactory, weapons)
        {
        }

        public override string Execute()
        {
            try
            {
                var weaponTypeArgs = this.Data[1].Split();
                Rarity weaponRarity = (Rarity)Enum.Parse(typeof(Rarity), weaponTypeArgs[0]);
                string weaponType = weaponTypeArgs[1];
                var weaponName = this.Data[2];
                
                var currentWeapon = this.WeaponFactory.CreateWeapon(weaponType, weaponName, weaponRarity);
                this.Weapons.AddWeapon(currentWeapon);

                return $"{weaponName} successfuly created!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
