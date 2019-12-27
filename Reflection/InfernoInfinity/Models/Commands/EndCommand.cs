namespace OOP.Reflection.InfernoInfinity.Models.Commands
{
    using OOP.Reflection.InfernoInfinity.Contracts;

    public class EndCommand : Command
    {
        public EndCommand(string[] data, IWeaponFactory weaponFactory, IGemFactory gemFactory, IWeaponRepository weapons)
            : base(data, weaponFactory, gemFactory, weapons)
        {
        }

        public override string Execute()
        {
            return this.Weapons.PrintAllWeapons();
        }
    }
}
