namespace OOP.Events.KingsGambit
{
    using OOP.Events.KingsGambit.Core;

    public class Startup : IService
    {
        public void Execute()
        {
            var engine = new Engine();
            engine.Run();
        }
    }
}
