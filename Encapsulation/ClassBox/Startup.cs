namespace OOP.Encapsulation.ClassBox
{
    using System;

    public class Startup
    {
        public static void Execute()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            var box = new Box(length, width, height);

            Console.WriteLine(box);
        }
    }
}