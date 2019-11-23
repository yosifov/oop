namespace OOP.Inheritance.Animals.Animals
{
    public class Tomcat : Animal
    {
        public Tomcat(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = "Male";
        }

        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
