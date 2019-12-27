namespace OOP.Reflection.InfernoInfinity.Models.Commands
{
    using OOP.Reflection.InfernoInfinity.Contracts;

    public abstract class Command : IExecutable
    {
        public Command(string[] data, IWeaponFactory weaponFactory, IGemFactory gemFactory, IWeaponRepository weapons)
        {
            this.Data = data;
            this.WeaponFactory = weaponFactory;
            this.GemFactory = gemFactory;
            this.Weapons = weapons;
        }

        protected string[] Data { get; private set; }

        protected IWeaponFactory WeaponFactory { get; private set; }

        protected IGemFactory GemFactory { get; private set; }

        protected IWeaponRepository Weapons { get; private set; }

        public abstract string Execute();
    }
}
