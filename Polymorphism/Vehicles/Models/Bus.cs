namespace OOP.Polymorphism.Vehicles.Models
{
    public class Bus : Vehicle
    {
        public Bus(double tankCapacity, double fuelQuantity, double fuelConsumptionPerKm, bool isConditionerOn, bool isTankLeaky) 
            : base(tankCapacity, fuelQuantity, fuelConsumptionPerKm, isConditionerOn, isTankLeaky)
        {
        }

        public override double SummerFuelConsumptionIncreasePerKm => 1.4;

        public override double RefuelCapacityPercentageIfLeaky => 95;

        public string DriveEmpty(double fuel)
        {
            this.IsConditionerOn = false;
            return base.Drive(fuel);
        }

        public override string Drive(double distance)
        {
            this.IsConditionerOn = true;
            return base.Drive(distance);
        }
    }
}
