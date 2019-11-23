namespace OOP.Interfaces.Shapes
{
    using System;
    using System.Text;

    public class Circle : IDrawable
    {
        private int radius;

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public int Radius
        {
            get => this.radius;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius value cannot be negative");
                }

                this.radius = value;
            }
        }

        public string Draw()
        {
            var sb = new StringBuilder();

            double radIn = this.Radius - 0.4;
            double radOut = this.Radius + 0.4;
            for (double y = this.Radius; y >= -this.Radius; --y)
            {
                for (double x = -this.Radius; x < radOut; x += 0.5)
                {
                    double value = (x * x) + (y * y);

                    if (value >= radIn * radIn && value <= radOut * radOut)
                    {
                        sb.Append("*");
                    }
                    else
                    {
                        sb.Append(" ");
                    }
                }

                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
