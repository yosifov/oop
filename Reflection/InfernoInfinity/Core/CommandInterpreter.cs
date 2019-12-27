namespace OOP.Reflection.InfernoInfinity.Core
{
    using System;
    using System.Linq;
    using System.Reflection;
    using OOP.Reflection.InfernoInfinity.Contracts;

    public class CommandInterpreter : ICommandInterpreter
    {
        private IWeaponFactory weaponFactory;
        private IGemFactory gemFactory;
        private IWeaponRepository weapons;

        public CommandInterpreter(IWeaponFactory weaponFactory, IGemFactory gemFactory, IWeaponRepository weapons)
        {
            this.weaponFactory = weaponFactory;
            this.gemFactory = gemFactory;
            this.weapons = weapons;
        }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            var command = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name.ToLower() == commandName.ToLower() + "command");

            if (command == null)
            {
                throw new InvalidOperationException("Invalid command");
            }

            var instance = (IExecutable)Activator.CreateInstance(command, new object[] { data, this.weaponFactory, this.gemFactory, this.weapons });

            return instance;
        }
    }
}
