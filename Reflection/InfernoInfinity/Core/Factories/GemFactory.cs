namespace OOP.Reflection.InfernoInfinity.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using OOP.Reflection.InfernoInfinity.Contracts;
    using OOP.Reflection.InfernoInfinity.Enums;

    public class GemFactory : IGemFactory
    {
        public IGem CreateGem(string gemType, Clarity clarity)
        {
            var gem = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name.ToLower() == gemType.ToLower());

            if (gem == null)
            {
                throw new InvalidOperationException("Invalid gem");
            }

            var instance = (IGem)Activator.CreateInstance(gem, new object[] { clarity });

            return instance;
        }
    }
}
