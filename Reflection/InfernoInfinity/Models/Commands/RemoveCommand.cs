namespace OOP.Reflection.InfernoInfinity.Models.Commands
{
    using System;
    using OOP.Reflection.InfernoInfinity.Contracts;

    public class RemoveCommand : IExecutable
    {
        private readonly IWeaponRepository weapons;

        public RemoveCommand(IWeaponRepository weapons)
        {
            this.weapons = weapons;
        }

        public string Execute(string[] data)
        {
            if (data.Length != 2)
            {
                return "Invalid command arguments";
            }

            try
            {
                string weaponName = data[0];
                int gemIndex = int.Parse(data[1]);

                this.weapons.RemoveGemFromWeapon(weaponName, gemIndex);

                return $"Gem on position {gemIndex} successfuly removed";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
