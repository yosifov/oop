namespace OOP.Polymorphism.Vehicles.Models
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumptionPerKm, bool isSummer, bool isTankLeaky) 
            : base(fuelQuantity, fuelConsumptionPerKm, isSummer, isTankLeaky)
        {
        }

        public override double SummerFuelConsumptionIncreasePerKm => 0.9;

        public override double RefuelCapacityPercentageIfLeaky => 95;
    }
}
