namespace OOP.Polymorphism.WildFarm.Models.Animals.Birds
{
    using System.Text;

    public abstract class Bird : Animal
    {
        public Bird(string name, double weight, double wingSize)
            : base(name, weight)
        {
            this.WingSize = wingSize;
        }

        public double WingSize { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]");
            
            return sb.ToString();
        }
    }
}
