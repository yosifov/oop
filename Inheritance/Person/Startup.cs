namespace OOP.Inheritance.Person
{
    using System;

    public class Startup
    {
        public static void Execute()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            try
            {
                Child child = new Child(name, age);
                Console.WriteLine(child);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
