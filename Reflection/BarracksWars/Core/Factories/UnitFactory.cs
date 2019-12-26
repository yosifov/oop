namespace OOP.Reflection.BarracksWars.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public UnitFactory()
        {
        }

        public IUnit CreateUnit(string unitType)
        {
            var currentUnitType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(u => u.Name == unitType);

            if (currentUnitType == null)
            {
                throw new InvalidOperationException("Invalid unit");
            }

            var currentUnitInstance = (IUnit)Activator.CreateInstance(currentUnitType);

            return currentUnitInstance;
        }
    }
}
