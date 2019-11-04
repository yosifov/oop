namespace OOP.Encapsulation.ClassBox
{
    using System.Text;

    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public double GetSurfaceArea()
        {
            double surfaceArea = (2 * this.length * this.width) 
                + (2 * this.length * this.height) 
                + (2 * this.width * this.height);
            
            return surfaceArea;
        }

        public double GetLateralSurfaceArea()
        {
            double lateralSurfaceArea = (2 * this.length * this.height) 
                + (2 * this.width * this.height);

            return lateralSurfaceArea;
        }

        public double GetVolume()
        {
            double volume = this.length * this.height * this.width;

            return volume;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {this.GetSurfaceArea():F2}");
            sb.AppendLine($"Lateral Surface Area - {this.GetLateralSurfaceArea():F2}");
            sb.Append($"Volume - {this.GetVolume():F2}");
            return sb.ToString();
        }
    }
}