namespace OOP.Inheritance.Lab
{
    public class Dog : Animal
    {
        public Dog(string name) 
            : base(name)
        {
            this.Name = name;
        }

        public string Bark()
        {
            return $"{this.Name} is barking...";
        }
    }
}