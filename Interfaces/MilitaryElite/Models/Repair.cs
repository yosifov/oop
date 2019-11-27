namespace OOP.Interfaces.MilitaryElite.Models
{
    using System;

    public class Repair
    {
        private string partName;
        private int hoursWorked;

        public Repair(string partName, int hoursWorked)
        {
            this.PartName = partName;
            this.HoursWorked = hoursWorked;
        }

        public string PartName
        {
            get => this.partName;
            private set
            {
                Validator.ValidateNotNull(value, nameof(this.PartName));
                this.partName = value;
            }
        }

        public int HoursWorked
        {
            get => this.hoursWorked;
            private set 
            {
                if (value < 1)
                {
                    throw new ArgumentException("Invalid hours worked");
                }

                this.hoursWorked = value; 
            }
        }

        public override string ToString()
        {
            return $"Part Name: {this.PartName} Hours Worked: {this.HoursWorked}";
        }
    }
}
