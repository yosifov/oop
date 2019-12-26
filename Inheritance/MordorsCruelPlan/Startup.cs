namespace OOP.Inheritance.MordorsCruelPlan
{
    using System;

    public class Startup : IService
    {
        public void Execute()
        {
            var wizard = new Wizard("Gandalf the Gray");

            var foodList = Console.ReadLine()
                .Split();

            foreach (var food in foodList)
            {
                wizard.Eat(food);
            }

            Console.WriteLine(wizard);
        }
    }
}
