namespace OOP.Inheritance.Lab
{
    public class Puppy : Dog
    {
        public Puppy(string name)
            : base(name)
        {
            this.Name = name;
        }

        public string Weep()
        {
            return $"{this.Name} is weeping...";
        }
    }
}
