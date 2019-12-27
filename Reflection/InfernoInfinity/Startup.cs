namespace OOP.Reflection.InfernoInfinity
{
    using System.Collections.Generic;
    using OOP.Reflection.InfernoInfinity.Contracts;
    using OOP.Reflection.InfernoInfinity.Core;
    using OOP.Reflection.InfernoInfinity.Core.Factories;
    using OOP.Reflection.InfernoInfinity.Data;

    public class Startup : IService
    {
        public void Execute()
        {
            IWeaponFactory weaponFactory = new WeaponFactory();
            IGemFactory gemFactory = new GemFactory();
            IWeaponRepository weapons = new WeaponRepository();
            var commandInterpreter = new CommandInterpreter(weaponFactory, gemFactory, weapons);
            var engine = new Engine(commandInterpreter);
            engine.Run();
        }
    }
}
