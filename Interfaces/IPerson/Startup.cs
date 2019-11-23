namespace OOP.Interfaces.IPerson
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Startup
    {
        public static void Execute()
        {
            try
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());
                IPerson person = new Citizen(name, age);
                Console.WriteLine(person.Name);
                Console.WriteLine(person.Age);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}
