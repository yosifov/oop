namespace OOP.Reflection.InfernoInfinity.Models.Commands
{
    using OOP.Reflection.InfernoInfinity.Contracts;

    public class EndCommand : IExecutable
    {
        private readonly IWeaponRepository weapons;

        public EndCommand(IWeaponRepository weapons)
        {
            this.weapons = weapons;
        }

        public string Execute(string[] data)
        {
            return this.weapons.PrintAllWeapons();
        }
    }
}
