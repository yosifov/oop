namespace OOP.Inheritance.Animals.Animals
{
    public class Kitten : Animal
    {
        public Kitten(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = "Female";
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
