namespace OOP.Polymorphism.Vehicles.Models
{
    using OOP.Polymorphism.Vehicles.Validations;
    using System;

    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumptionPerKm;
        private double distanceDriven;
        private double tankCapacity;

        public Vehicle(double tankCapacity, double fuelQuantity, double fuelConsumptionPerKm, bool isConditionerOn, bool isTankLeaky)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
            this.DistanceDriven = 0;
            this.IsConditionerOn = isConditionerOn;
            this.IsTankLeaky = isTankLeaky;
        }

        public double FuelQuantity
        {
            get => this.fuelQuantity;
            protected set
            {
                Validator.ValidateNegative(value, nameof(this.FuelQuantity));
                if (value > this.TankCapacity)
                {
                    this.fuelQuantity = 0;
                }
                else
                {
                    this.fuelQuantity = value;
                }
            }
        }

        public double FuelConsumptionPerKm
        {
            get => this.fuelConsumptionPerKm;
            protected set
            {
                Validator.ValidateNegative(value, nameof(this.FuelConsumptionPerKm));
                this.fuelConsumptionPerKm = value;
            }
        }

        public double DistanceDriven
        {
            get => this.distanceDriven;
            protected set
            {
                Validator.ValidateNegative(value, nameof(this.DistanceDriven));
                this.distanceDriven = value;
            }
        }

        public double TankCapacity
        {
            get => this.tankCapacity;
            protected set
            {
                Validator.ValidateNegative(value, nameof(this.TankCapacity));
                this.tankCapacity = value;
            }
        }

        public bool IsConditionerOn { get; protected set; }

        public bool IsTankLeaky { get; protected set; }

        public abstract double SummerFuelConsumptionIncreasePerKm { get; }

        public abstract double RefuelCapacityPercentageIfLeaky { get; }

        public virtual string Drive(double distance)
        {
            double distanceCanDrive = this.FuelQuantity /
                (this.FuelConsumptionPerKm + (this.IsConditionerOn ? this.SummerFuelConsumptionIncreasePerKm : 0));

            if (distanceCanDrive >= distance)
            {
                this.DistanceDriven += distance;
                this.FuelQuantity -= distance *
                    (this.FuelConsumptionPerKm + (this.IsConditionerOn ? this.SummerFuelConsumptionIncreasePerKm : 0));
                return $"{this.GetType().Name} travelled {distance} km";
            }
            else
            {
                return $"{this.GetType().Name} needs refueling";
            }
        }

        public void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                double fuelAmount = fuel * (this.IsTankLeaky ? this.RefuelCapacityPercentageIfLeaky * 0.01 : 1);
                if (this.FuelQuantity + fuelAmount > this.TankCapacity)
                {
                    Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
                }
                else
                {
                    this.FuelQuantity += fuelAmount;
                }
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}
