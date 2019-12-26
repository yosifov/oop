namespace OOP.Interfaces.Ferrari
{
    using System;

    public class Startup : IService
    {
        public void Execute()
        {
            string driverName = Console.ReadLine();

            var ferrari = new Ferrari(driverName);

            Console.WriteLine(ferrari);
        }
    }
}
