namespace OOP.Interfaces.Cars
{
    using System;
    using System.Text;

    public abstract class Car : ICar
    {
        private string model;
        private string color;

        public Car(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public string Model
        {
            get => this.model;
            protected set
            {
                ValidateName(value, nameof(this.model));

                this.model = value;
            }
        }

        public string Color
        {
            get => this.color;
            protected set
            {
                ValidateName(value, nameof(this.color));

                this.color = value;
            }
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Color} {this.GetType().Name} {this.Model}");
            sb.AppendLine(this.Start());
            sb.AppendLine(this.Stop());
            return sb.ToString().TrimEnd();
        }

        private static void ValidateName(string value, string type)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"Invalid {type} name");
            }
        }
    }
}
