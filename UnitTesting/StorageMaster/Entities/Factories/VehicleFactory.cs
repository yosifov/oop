namespace OOP.UnitTesting.StorageMaster.Entities.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using StorageMaster.Entities.Vehicles;

    public class VehicleFactory
    {
        public Vehicle CreateVehicle(string type)
        {
            var vehicleType = this.GetType()
                .Assembly
                .GetTypes()
                .FirstOrDefault(t => typeof(Vehicle).IsAssignableFrom(t) && !t.IsAbstract && t.Name == type);

            if (vehicleType == null)
            {
                throw new InvalidOperationException("Invalid vehicle type!");
            }

            try
            {
                var storage = (Vehicle)Activator.CreateInstance(vehicleType);
                return storage;
            }
            catch (TargetInvocationException e)
            {
                throw e.InnerException;
            }
        }
    }
}