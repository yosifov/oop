namespace OOP.Polymorphism.Vehicles.Models
{
    public class Truck : Vehicle
    {
        public Truck(double tankCapacity, double fuelQuantity, double fuelConsumptionPerKm, bool isConditionerOn, bool isTankLeaky) 
            : base(tankCapacity, fuelQuantity, fuelConsumptionPerKm, isConditionerOn, isTankLeaky)
        {
        }

        public override double SummerFuelConsumptionIncreasePerKm => 1.6;

        public override double RefuelCapacityPercentageIfLeaky => 95;
    }
}
