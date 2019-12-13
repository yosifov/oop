namespace OOP.Polymorphism.Vehicles.Models
{
    public class Car : Vehicle
    {
        public Car(double tankCapacity, double fuelQuantity, double fuelConsumptionPerKm, bool isConditionerOn, bool isTankLeaky) 
            : base(tankCapacity, fuelQuantity, fuelConsumptionPerKm, isConditionerOn, isTankLeaky)
        {
        }

        public override double SummerFuelConsumptionIncreasePerKm => 0.9;

        public override double RefuelCapacityPercentageIfLeaky => 95;
    }
}
