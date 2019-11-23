namespace OOP.Interfaces.Shapes
{
    using System;
    using System.Text;

    public class Rectangle : IDrawable
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width
        {
            get => this.width;
            private set
            {
                ValidateSide(value, nameof(this.width));

                this.width = value;
            }
        }

        public int Height
        {
            get => this.height;
            set
            {
                ValidateSide(value, nameof(this.height));

                this.height = value;
            }
        }

        public string Draw()
        {
            var sb = new StringBuilder();

            this.DrawLine(this.Width, '*', '*', sb);

            for (int i = 1; i < this.Height - 1; ++i)
            {
                this.DrawLine(this.Width, '*', ' ', sb);
            }

            this.DrawLine(this.Width, '*', '*', sb);

            return sb.ToString();
        }

        private static void ValidateSide(int value, string type)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Rectangle {type} cannot be negative");
            }
        }

        private void DrawLine(int width, char end, char mid, StringBuilder sb)
        {
            sb.Append(end);
            for (int i = 1; i < width - 1; ++i)
            {
                sb.Append(mid);
            }

            sb.AppendLine(end.ToString());
        }
    }
}
