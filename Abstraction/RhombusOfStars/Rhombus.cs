namespace OOP.Abstraction.RhombusOfStars
{
    using System;
    using System.Text;

    public class Rhombus
    {
        public static void Execute()
        {
            int count = int.Parse(Console.ReadLine());
            PrintRhombus(count);
        }

        private static void PrintRhombus(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                PrintRhombusRow(i, count);
            }
            for (int i = count - 1; i > 0; i--)
            {
                PrintRhombusRow(i, count);
            }
        }

        private static void PrintRhombusRow(int stars, int totalStars)
        {
            var sb = new StringBuilder();

            sb.Append(new string(' ', totalStars - stars));

            for (int i = 1; i <= stars; i++)
            {
                sb.Append("* ");
            }

            Console.WriteLine(sb);
        }
    }
}
