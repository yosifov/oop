namespace OOP.Reflection.InfernoInfinity.Models.Commands
{
    using OOP.Reflection.InfernoInfinity.Contracts;

    public class PrintCommand : Command
    {
        public PrintCommand(string[] data, IWeaponFactory weaponFactory, IGemFactory gemFactory, IWeaponRepository weapons)
            : base(data, weaponFactory, gemFactory, weapons)
        {
        }

        public override string Execute()
        {
            if (this.Data.Length != 2)
            {
                return "Invalid command arguments";
            }

            string weaponName = this.Data[1];

            return this.Weapons.PrintWeapon(weaponName);
        }
    }
}
