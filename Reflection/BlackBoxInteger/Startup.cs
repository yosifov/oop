namespace OOP.Reflection.BlackBoxInteger
{
    using System;

    public class Startup : IService
    {
        public void Execute()
        {
            var blackBoxIntegerTests = new BlackBoxIntegerTests();

            string input = Console.ReadLine();

            while (input != "END")
            {
                var inputArgs = input.Split("_");
                string command = inputArgs[0];
                int value = int.Parse(inputArgs[1]);
                blackBoxIntegerTests.Run(command, value);

                input = Console.ReadLine();
            }
        }
    }
}
