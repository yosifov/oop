namespace OOP.Inheritance.Lab
{
    public class Cat : Animal
    {
        public Cat(string name) 
            : base(name)
        {
            this.Name = name;
        }

        public string Meow()
        {
            return $"{this.Name} is meowing...";
        }
    }
}
