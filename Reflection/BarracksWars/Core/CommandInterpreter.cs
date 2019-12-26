namespace OOP.Reflection.BarracksWars.Core
{
    using System;
    using System.Linq;
    using System.Reflection;
    using OOP.Reflection.BarracksWars.Contracts;

    public class CommandInterpreter : ICommandInterpreter
    {
        private IRepository repository;
        private IUnitFactory unitFacotry;

        public CommandInterpreter(IRepository repository, IUnitFactory unitFacotry)
        {
            this.repository = repository;
            this.unitFacotry = unitFacotry;
        }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            var type = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name.ToLower() == commandName.ToLower());

            if (type == null)
            {
                throw new InvalidOperationException("Invalid command");
            }

            return Activator.CreateInstance(type, new object[] { data, this.repository, this.unitFacotry }) as IExecutable;
        }
    }
}
