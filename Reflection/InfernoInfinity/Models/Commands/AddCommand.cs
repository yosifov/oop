namespace OOP.Reflection.InfernoInfinity.Models.Commands
{
    using System;
    using OOP.Reflection.InfernoInfinity.Contracts;
    using OOP.Reflection.InfernoInfinity.Enums;

    public class AddCommand : IExecutable
    {
        private readonly IGemFactory gemFactory;
        private readonly IWeaponRepository weapons;

        public AddCommand(IGemFactory gemFactory, IWeaponRepository weapons)
        {
            this.gemFactory = gemFactory;
            this.weapons = weapons;
        }

        public string Execute(string[] data)
        {
            if (data.Length != 3)
            {
                return "Invalid command arguments";
            }

            try
            {
                var weaponName = data[0];
                int gemIndex = int.Parse(data[1]);
                string[] gemArgs = data[2].Split();
                Clarity gemClarityType = (Clarity)Enum.Parse(typeof(Clarity), gemArgs[0]);
                string gemType = gemArgs[1];
                var currentGem = this.gemFactory.CreateGem(gemType, gemClarityType);

                this.weapons.AddGemToWeapon(weaponName, gemIndex, currentGem);

                return $"{gemType} successfuly added to {weaponName}";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
