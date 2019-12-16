namespace OOP.Polymorphism.WildFarm.Models.Animals.Mammals
{
    using OOP.Polymorphism.WildFarm.Models.Foods;
    using System;
    using System.Collections.Generic;

    public class Mouse : Mammal
    {
        private List<string> foodThatEat = new List<string>()
        {
            "Vegetable",
            "Fruit"
        };

        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override double WeightIndex => 0.10;

        public override string ProduceSound()
        {
            return "Squeak";
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
