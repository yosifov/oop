namespace OOP.Reflection.InfernoInfinity.Core
{
    using System;
    using Microsoft.Extensions.DependencyInjection;
    using OOP.Reflection.InfernoInfinity.Contracts;

    public class Engine
    {
        private IServiceProvider serviceProvider;

        public Engine(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void Run()
        {
            try
            {
                while (true)
                {
                    string[] userInput = Console.ReadLine().Trim()
                        .Split(";");

                    if (userInput.Length < 1 || userInput.Length > 4)
                    {
                        throw new ArgumentException("Invalid user input");
                    }

                    var commandInterpreter = this.serviceProvider.GetService<ICommandInterpreter>();

                    string result = commandInterpreter.Read(userInput);

                    Console.WriteLine(result);

                    if (userInput[0].ToLower() == "end")
                    {
                        break;
                    }
                }
            }
            catch (ArgumentException ax)
            {
                Console.WriteLine(ax.Message);
            }
            catch (InvalidOperationException iox)
            {
                Console.WriteLine(iox.Message);
            }
        }
    }
}
