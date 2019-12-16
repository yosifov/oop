namespace OOP.Polymorphism.WildFarm.Models.Animals.Mammals.Felines
{
    using OOP.Polymorphism.WildFarm.Models.Foods;
    using System;
    using System.Collections.Generic;

    public class Cat : Feline
    {
        private List<string> foodThatEat = new List<string>()
        {
            "Vegetable",
            "Meat"
        };

        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override double WeightIndex => 0.30;

        public override string ProduceSound()
        {
            return "Meow";
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
