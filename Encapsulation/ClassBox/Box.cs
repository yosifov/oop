﻿namespace OOP.Encapsulation.ClassBox
{
    using System;
    using System.Text;

    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length 
        {
            get => this.length;
            private set
            {
                this.ValidateSide(value, nameof(this.Length));

                this.length = value;
            }
        }

        public double Width
        {
            get => this.width;
            private set 
            {
                this.ValidateSide(value, nameof(this.Width));

                this.width = value;
            }
        }

        public double Height 
        {
            get => this.height; 
            set
            {
                this.ValidateSide(value, nameof(this.Height));

                this.height = value;
            }
        }

        public double GetSurfaceArea()
        {
            double surfaceArea = 2 * (this.length + this.GetLateralSurfaceArea());
            
            return surfaceArea;
        }

        public double GetLateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * ((this.length * this.height) + (this.width * this.height));

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

        private void ValidateSide(double value, string parameterName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{parameterName} cannot be zero or negative.");
            }
        }
    }
}