namespace OOP.Inheritance.StackOfStrings
{
    using System;
    using System.Collections.Generic;
    
    public class Startup
    {
        public static void Execute()
        {
            var stackOfStrings = new StackOfStrings();
            
            Console.WriteLine(stackOfStrings.IsEmpty());

            stackOfStrings.AddRange(new List<string>() { "first", "second" });

            Console.WriteLine(stackOfStrings.IsEmpty());
        }
    }
}
