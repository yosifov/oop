namespace OOP.Interfaces.Shapes
{
    using System;

    public class Startup : IService
    {
        public void Execute()
        {
            var radius = int.Parse(Console.ReadLine());
            IDrawable circle = new Circle(radius);

            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            IDrawable rect = new Rectangle(width, height);

            Console.WriteLine(circle.Draw());
            Console.WriteLine(rect.Draw());
        }
    }
}
