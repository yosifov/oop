namespace OOP.Interfaces.Telephony
{
    using System;
    using System.Linq;

    public class Startup : IService
    {
        public void Execute()
        {
            var smartphone = new Smartphone();

            var numbers = Console.ReadLine().Split();
            var urls = Console.ReadLine().Split();

            try
            {
                numbers.ToList().ForEach(x => Console.WriteLine(smartphone.Call(x)));
                urls.ToList().ForEach(x => Console.WriteLine(smartphone.Browse(x)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
