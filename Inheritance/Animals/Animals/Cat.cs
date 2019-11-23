namespace OOP.Inheritance.Animals.Animals
{
    public class Cat : Animal
    {
        public Cat(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public override string ProduceSound()
        {
            return "Meow meow";
        }
    }
}
