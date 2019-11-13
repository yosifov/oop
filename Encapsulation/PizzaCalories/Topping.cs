namespace OOP.Encapsulation.PizzaCalories
{
    using System;
    using System.Collections.Generic;

    public class Topping
    {
        private const double BaseCaloriesPerGram = 2;
        private Dictionary<string, double> availableTypes = new Dictionary<string, double>()
        {
            { "meat", 1.2 },
            { "veggies", 0.8 },
            { "cheese", 1.1 },
            { "sauce", 0.9 }
        };

        private string type;
        private int weight;

        public Topping(string type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public string Type
        {
            get => this.type;
            private set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException("Topping type cannot be empty.");
                }
                else if (this.availableTypes.ContainsKey(value.ToLower()))
                {
                    this.type = value;
                }
                else
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
            }
        }

        public int Weight
        {
            get => this.weight;
            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
                }

                this.weight = value;
            }
        }

        public double GetCalories()
        {
            return BaseCaloriesPerGram * this.Weight * this.availableTypes[this.Type.ToLower()];
        }
    }
}
