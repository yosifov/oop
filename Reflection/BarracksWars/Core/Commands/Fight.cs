namespace OOP.Reflection.BarracksWars.Core.Commands
{
    using System;
    using OOP.Reflection.BarracksWars.Contracts;

    public class Fight : Command
    {
        public Fight(string[] data, IRepository repository, IUnitFactory unitFactory) 
            : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            Environment.Exit(0);
            return null;
        }
    }
}
