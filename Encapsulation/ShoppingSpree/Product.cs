namespace OOP.Encapsulation.ShoppingSpree
{
    using System;

    public class Product
    {
        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name 
        {
            get => this.name; 
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Name cannot be empty.");
                }

                this.name = value;
            } 
        }

        public decimal Cost 
        {
            get => this.cost; 
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cost cannot be negative number.");
                }

                this.cost = value;
            } 
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
