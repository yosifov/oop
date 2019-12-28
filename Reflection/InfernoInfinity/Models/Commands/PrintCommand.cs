namespace OOP.Reflection.InfernoInfinity.Models.Commands
{
    using OOP.Reflection.InfernoInfinity.Contracts;

    public class PrintCommand : IExecutable
    {
        private readonly IWeaponRepository weapons;

        public PrintCommand(IWeaponRepository weapons)
        {
            this.weapons = weapons;
        }

        public string Execute(string[] data)
        {
            if (data.Length != 1)
            {
                return "Invalid command arguments";
            }

            string weaponName = data[0];

            return this.weapons.PrintWeapon(weaponName);
        }
    }
}
