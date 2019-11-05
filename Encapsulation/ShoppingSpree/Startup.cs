namespace OOP.Encapsulation.ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Execute()
        {
            var people = new List<Person>();
            var products = new List<Product>();

            var peopleParameters = Console.ReadLine().Split(";");
            var productsParameters = Console.ReadLine().Split(";");

            foreach (var person in peopleParameters)
            {
                var parameters = person.Split("=");
                if (parameters.Length == 2)
                {
                    string name = parameters[0];
                    decimal money = decimal.Parse(parameters[1]);
                    try
                    {
                        people.Add(new Person(name, money));
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                        return;
                    }
                }
            }

            foreach (var product in productsParameters)
            {
                var parameters = product.Split("=");
                if (parameters.Length == 2)
                {
                    string name = parameters[0];
                    decimal cost = decimal.Parse(parameters[1]);
                    try
                    {
                        products.Add(new Product(name, cost));
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                        return;
                    }
                }
            }

            var input = Console.ReadLine();

            while (input != "END")
            {
                var parameters = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                string personName = parameters[0];
                string productName = parameters[1];

                Person currentPerson = people.FirstOrDefault(x => x.Name.Equals(personName));
                Product currentProduct = products.FirstOrDefault(x => x.Name.Equals(productName));

                currentPerson.Buy(currentProduct);

                input = Console.ReadLine();
            }

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
