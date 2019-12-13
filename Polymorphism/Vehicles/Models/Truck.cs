namespace OOP.Polymorphism.Vehicles.Models
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumptionPerKm, bool isSummer, bool isTankLeaky) 
            : base(fuelQuantity, fuelConsumptionPerKm, isSummer, isTankLeaky)
        {
        }

        public override double SummerFuelConsumptionIncreasePerKm => 1.6;

        public override double RefuelCapacityPercentageIfLeaky => 95;
    }
}
