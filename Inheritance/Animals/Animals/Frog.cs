namespace OOP.Inheritance.Animals.Animals
{
    public class Frog : Animal
    {
        public Frog(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public override string ProduceSound()
        {
            return "Ribbit";
        }
    }
}
