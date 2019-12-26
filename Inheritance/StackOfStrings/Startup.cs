namespace OOP.Inheritance.StackOfStrings
{
    using System;
    using System.Collections.Generic;
    
    public class Startup : IService
    {
        public void Execute()
        {
            var stackOfStrings = new StackOfStrings();
            
            Console.WriteLine(stackOfStrings.IsEmpty());

            stackOfStrings.AddRange(new List<string>() { "first", "second" });

            Console.WriteLine(stackOfStrings.IsEmpty());
        }
    }
}
