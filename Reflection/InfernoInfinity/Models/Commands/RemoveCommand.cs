namespace OOP.Reflection.InfernoInfinity.Models.Commands
{
    using System;
    using OOP.Reflection.InfernoInfinity.Contracts;

    public class RemoveCommand : Command
    {
        public RemoveCommand(string[] data, IWeaponFactory weaponFactory, IGemFactory gemFactory, IWeaponRepository weapons)
            : base(data, weaponFactory, gemFactory, weapons)
        {
        }

        public override string Execute()
        {
            if (this.Data.Length != 3)
            {
                return "Invalid command arguments";
            }

            try
            {
                string weaponName = this.Data[1];
                int gemIndex = int.Parse(this.Data[2]);

                this.Weapons.RemoveGemFromWeapon(weaponName, gemIndex);

                return $"Gem on position {gemIndex} successfuly removed";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
