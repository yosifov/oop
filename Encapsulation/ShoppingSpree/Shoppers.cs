
namespace OOP.Encapsulation.ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Shoppers
    {
        private List<Person> list;

        public Shoppers()
        {
            this.list = new List<Person>();
        }

        public void AddMany(string[] parameters)
        {
            foreach (var parameter in parameters)
            {
                var person = parameter.Split("=");
                if (person.Length == 2)
                {
                    string name = person[0];
                    decimal money = decimal.Parse(person[1]);
                    try
                    {
                        this.list.Add(new Person(name, money));
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                        throw;
                    }
                }
            }
        }

        public void BuyProduct(string[] parameters, ProductCatalog products)
        {
            string personName = parameters[0];
            string productName = parameters[1];

            Person currentPerson = this.list.FirstOrDefault(x => x.Name.Equals(personName));
            Product currentProduct = products.Catalog.FirstOrDefault(x => x.Name.Equals(productName));

            currentPerson.AddToBag(currentProduct);
        }

        public void Print()
        {
            foreach (var person in this.list)
            {
                Console.WriteLine(person);
            }
        }
    }
}
