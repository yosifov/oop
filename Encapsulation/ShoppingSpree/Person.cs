namespace OOP.Encapsulation.ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bag = new List<Product>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Product name cannot be empty.");
                }

                this.name = value;
            }
        }

        public decimal Money 
        {
            get => this.money; 
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.money = value;
            } 
        }

        public void AddToBag(Product product)
        {
            if (this.money - product.Cost < 0)
            {
                Console.WriteLine($"{this.name} can't afford {product.Name}");
            }
            else
            {
                this.bag.Add(product);
                this.money -= product.Cost;
                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"{this.Name} - ");
            
            if (this.bag.Count == 0)
            {
                sb.Append("Nothing bought");
            }
            else
            {
                sb.Append(string.Join(", ", this.bag));
            }

            return sb.ToString();
        }
    }
}
