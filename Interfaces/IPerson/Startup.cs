namespace OOP.Interfaces.IPerson
{
    using System;

    public class Startup : IService
    {
        public void Execute()
        {
            try
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());
                string id = Console.ReadLine();
                string birthdate = Console.ReadLine();
                IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
                IBirthable birthable = new Citizen(name, age, id, birthdate);
                Console.WriteLine(identifiable.Id);
                Console.WriteLine(birthable.Birthdate);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}
