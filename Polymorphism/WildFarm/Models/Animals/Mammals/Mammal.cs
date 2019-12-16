namespace OOP.Polymorphism.WildFarm.Models.Animals.Mammals
{
    using System.Text;

    public abstract class Mammal : Animal
    {
        public Mammal(string name, double weight, string livingRegion)
            : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]");

            return sb.ToString();
        }
    }
}
