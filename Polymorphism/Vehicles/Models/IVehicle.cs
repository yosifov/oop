namespace OOP.Polymorphism.Vehicles.Models
{
    public interface IVehicle
    {
        double FuelQuantity { get; }

        double FuelConsumptionPerKm { get; }

        double DistanceDriven { get; }

        bool IsSummer { get; }

        bool IsTankLeaky { get; }

        double SummerFuelConsumptionIncreasePerKm { get; }

        double RefuelCapacityPercentageIfLeaky { get; }

        string Drive(double distance);

        void Refuel(double fuel);
    }
}
