namespace OOP.Inheritance.Animals.Animals
{
    public class Dog : Animal
    {
        public Dog(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}
