namespace OOP.UnitTesting.Database
{
    using System;

    public class Startup : IService
    {
        public void Execute()
        {
            Console.WriteLine("Database task for unit testing only");
        }
    }
}
