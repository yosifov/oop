namespace OOP.Polymorphism.WildFarm.Models.Animals
{
    using OOP.Polymorphism.WildFarm.Models.Foods;

    public abstract class Animal
    {
        protected Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = 0;
        }

        public string Name { get; }

        public double Weight { get; protected set; }

        public int FoodEaten { get; protected set; }

        protected abstract double WeightIndex { get; }

        public abstract string ProduceSound();

        public virtual void Eat(Food food)
        {
            this.Weight += food.Quantity * this.WeightIndex;
            this.FoodEaten += food.Quantity;
        }
    }
}
