namespace OOP.Reflection.BarracksWars.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        private Type[] unitTypes;
        private Type unitBaseType;

        public UnitFactory()
        {
            this.unitBaseType = Assembly
                    .GetExecutingAssembly()
                    .GetTypes()
                    .Where(t => t.Name == "Unit")
                    .FirstOrDefault();

            this.unitTypes = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(x => x.IsSubclassOf(this.unitBaseType))
                .ToArray();
        }

        public IUnit CreateUnit(string unitType)
        {
            var currentUnitType = this.unitTypes.FirstOrDefault(u => u.Name == unitType);
            var currentUnitInstance = (IUnit)Activator.CreateInstance(currentUnitType);

            return currentUnitInstance;
        }
    }
}
