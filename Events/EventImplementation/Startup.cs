namespace OOP.Events.EventImplementation
{
    using System;

    public class Startup : IService
    {
        public void Execute()
        {
            Dispatcher dispatcher = new Dispatcher();
            Handler handler = new Handler();

            dispatcher.NameChange += handler.OnDispatcherNameChange;

            string input = Console.ReadLine();

            while (input != "End")
            {
                dispatcher.Name = input;

                input = Console.ReadLine();
            }
        }
    }
}
