namespace OOP.Polymorphism.WildFarm.Models.Animals.Birds
{
    using OOP.Polymorphism.WildFarm.Models.Foods;
    using System;
    using System.Collections.Generic;

    public class Owl : Bird
    {
        private List<string> foodThatEat = new List<string>()
        {
            "Meat"
        };

        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override double WeightIndex => 0.25;

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }

        public override void Eat(Food food)
        {
            if (this.foodThatEat.Contains(food.GetType().Name))
            {
                base.Eat(food);
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
    }
}
