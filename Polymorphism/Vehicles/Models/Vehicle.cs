namespace OOP.Polymorphism.Vehicles.Models
{
    using OOP.Polymorphism.Vehicles.Validations;

    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumptionPerKm;
        private double distanceDriven;

        public Vehicle(double fuelQuantity, double fuelConsumptionPerKm, bool isSummer, bool isTankLeaky)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
            this.DistanceDriven = 0;
            this.IsSummer = isSummer;
            this.IsTankLeaky = isTankLeaky;
        }

        public double FuelQuantity
        {
            get => this.fuelQuantity;
            private set
            {
                Validator.ValidateNegative(value, nameof(this.FuelQuantity));
                this.fuelQuantity = value;
            }
        }

        public double FuelConsumptionPerKm
        {
            get => this.fuelConsumptionPerKm;
            private set
            {
                Validator.ValidateNegative(value, nameof(this.FuelConsumptionPerKm));
                this.fuelConsumptionPerKm = value;
            }
        }

        public double DistanceDriven
        {
            get => this.distanceDriven;
            private set
            {
                Validator.ValidateNegative(value, nameof(this.DistanceDriven));
                this.distanceDriven = value;
            }
        }

        public bool IsSummer { get; protected set; }

        public bool IsTankLeaky { get; protected set; }

        public abstract double SummerFuelConsumptionIncreasePerKm { get; }

        public abstract double RefuelCapacityPercentageIfLeaky { get; }

        public string Drive(double distance)
        {
            double distanceCanDrive = this.FuelQuantity / (this.FuelConsumptionPerKm + (this.IsSummer ? this.SummerFuelConsumptionIncreasePerKm : 0));

            if (distanceCanDrive >= distance)
            {
                this.DistanceDriven += distance;
                this.FuelQuantity -= distance * (this.FuelConsumptionPerKm + (this.IsSummer ? this.SummerFuelConsumptionIncreasePerKm : 0));
                return $"{this.GetType().Name} travelled {distance} km";
            }
            else
            {
                return $"{this.GetType().Name} needs refueling";
            }
        }

        public void Refuel(double fuel)
        {
            this.FuelQuantity += fuel * (this.IsTankLeaky ? this.RefuelCapacityPercentageIfLeaky * 0.01 : 1);
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}
