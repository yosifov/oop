namespace OOP.Reflection.InfernoInfinity.Models.Commands
{
    using System;
    using OOP.Reflection.InfernoInfinity.Contracts;
    using OOP.Reflection.InfernoInfinity.Enums;

    public class AddCommand : Command
    {
        public AddCommand(string[] data, IWeaponFactory weaponFactory, IGemFactory gemFactory, IWeaponRepository weapons)
            : base(data, weaponFactory, gemFactory, weapons)
        {
        }

        public override string Execute()
        {
            if (this.Data.Length != 4)
            {
                return "Invalid command arguments";
            }

            try
            {
                var weaponName = this.Data[1];
                int gemIndex = int.Parse(this.Data[2]);
                string[] gemArgs = this.Data[3].Split();
                Clarity gemClarityType = (Clarity)Enum.Parse(typeof(Clarity), gemArgs[0]);
                string gemType = gemArgs[1];
                var currentGem = this.GemFactory.CreateGem(gemType, gemClarityType);

                this.Weapons.AddGemToWeapon(weaponName, gemIndex, currentGem);

                return $"{gemType} successfuly added to {weaponName}";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
