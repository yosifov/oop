namespace OOP.Interfaces.Cars
{
    using System;
    using System.Text;

    public class Tesla : Car, IElectricCar
    {
        private int battery;

        public Tesla(string model, string color, int battery)
            : base(model, color)
        {
            this.Battery = battery;
        }

        public int Battery 
        {
            get => this.battery;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Electric car must have batteries");
                }

                this.battery = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Color} {this.GetType().Name} {this.Model} with {this.battery} batteries");
            sb.AppendLine(this.Start());
            sb.AppendLine(this.Stop());
            return sb.ToString().TrimEnd();
        }
    }
}
