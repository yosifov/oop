namespace OOP.UnitTesting.StorageMaster
{
    using Core;
    using Core.IO;
    using Core.IO.Contracts;

    public class Startup : IService
    {
        public void Execute()
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            var engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}
