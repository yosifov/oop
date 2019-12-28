namespace OOP.Reflection.InfernoInfinity.Core
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Microsoft.Extensions.DependencyInjection;
    using OOP.Reflection.InfernoInfinity.Contracts;

    public class CommandInterpreter : ICommandInterpreter
    {
        private const string Suffix = "command";
        private readonly IServiceProvider serviceProvider;

        public CommandInterpreter(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public string Read(string[] data)
        {
            string commandName = data[0].ToLower() + Suffix;
            string[] inputArgs = data.Skip(1).ToArray();

            var command = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name.ToLower() == commandName);

            if (command == null)
            {
                throw new ArgumentNullException("Invalid command");
            }

            var constructor = command
                .GetConstructors()
                .FirstOrDefault();

            var constructorParams = constructor
                .GetParameters()
                .Select(p => p.ParameterType)
                .ToArray();

            var services = constructorParams
                .Select(this.serviceProvider.GetService)
                .ToArray();

            var instance = (IExecutable)Activator.CreateInstance(command, services);

            string result = instance.Execute(inputArgs);

            return result;
        }
    }
}
