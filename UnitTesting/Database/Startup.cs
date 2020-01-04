namespace OOP.UnitTesting.Database
{
    using System;
    using System.Linq;

    public class Startup : IService
    {
        public void Execute()
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var database = new Database(elements);

            Console.WriteLine(string.Join(" ", database.Elements));
        }
    }
}
