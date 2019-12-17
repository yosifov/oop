namespace OOP.Polymorphism.WildFarm.Models.Animals.Birds
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        protected override double WeightIndex => 0.35;

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
