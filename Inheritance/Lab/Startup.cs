namespace OOP.Inheritance.Lab
{
    using System;

    public class Startup : IService
    {
        public void Execute()
        {
            try
            {
                var dog = new Dog("Bobby");
                Console.WriteLine(dog.Bark());
                Console.WriteLine(dog.Eat());

                var puppy = new Puppy("Fluffy");
                Console.WriteLine(puppy.Eat());
                Console.WriteLine(puppy.Bark());
                Console.WriteLine(puppy.Weep());

                var cat = new Cat("Tommas");
                Console.WriteLine(cat.Eat());
                Console.WriteLine(cat.Meow());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}
