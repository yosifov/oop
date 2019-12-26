namespace OOP.Reflection.TrafficLights
{
    using System;
    using System.Linq;

    public class Startup : IService
    {
        public void Execute()
        {
            var trafficLights = Console.ReadLine().Trim().Split()
                .Select(x => new TrafficLight(x))
                .ToList();

            var n = int.Parse(Console.ReadLine().Trim());

            for (int i = 0; i < n; i++)
            {
                trafficLights.ForEach(t => t.ToggleSignal());
                Console.WriteLine(string.Join(" ", trafficLights));
            }
        }
    }
}
