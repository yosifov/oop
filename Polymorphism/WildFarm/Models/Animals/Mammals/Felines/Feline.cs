namespace OOP.Polymorphism.WildFarm.Models.Animals.Mammals.Felines
{
    using System.Text;

    public abstract class Feline : Mammal
    {
        public Feline(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]");

            return sb.ToString();
        }
    }
}
