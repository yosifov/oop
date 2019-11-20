namespace OOP.Inheritance.MordorsCruelPlan.Foods
{
    public class OtherFood : Food
    {
        public OtherFood(string name)
        {
            this.Name = name;
        }

        public override string Name { get; }

        public override int Points => -1;
    }
}
