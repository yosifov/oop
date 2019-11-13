namespace OOP.Encapsulation.PizzaCalories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.dough = dough;
            this.toppings = new List<Topping>();
        }

        public IReadOnlyList<Topping> Toppings { get => this.toppings; }

        public string Name
        {
            get => this.name;
            private set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            if (this.Toppings.Count <= 9)
            {
                this.toppings.Add(topping);
            }
            else
            {
                throw new InvalidOperationException("Number of toppings should be in range [0..10].");
            }
        }

        public double GetCalories()
        {
            double doughCalories = this.dough.GetCalories();
            double toppingsCalories = this.toppings.Select(x => x.GetCalories()).Sum();

            return doughCalories + toppingsCalories;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.GetCalories():F2} Calories.";
        }
    }
}
