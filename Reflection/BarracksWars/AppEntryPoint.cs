namespace OOP.Reflection.BarracksWars
{
    using Contracts;
    using Core;
    using Core.Factories;
    using Data;

    public class AppEntryPoint
    {
        public static void Execute()
        {
            IRepository repository = new UnitRepository();
            IUnitFactory unitFactory = new UnitFactory();
            IRunnable engine = new Engine(repository, unitFactory);
            engine.Run();
        }
    }
}
