namespace OOP.Reflection.BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        private Type typeBlackBoxInteger;
        private object instanceBlackBoxInteger;
        private FieldInfo fieldBlackBoxInteger;

        public BlackBoxIntegerTests()
        {
            this.typeBlackBoxInteger = typeof(BlackBoxIntegerTests)
                .Assembly
                .GetTypes()
                .First(t => t.Name == "BlackBoxInteger");

            this.instanceBlackBoxInteger = Activator.CreateInstance(this.typeBlackBoxInteger, true);

            this.fieldBlackBoxInteger = this.typeBlackBoxInteger
                .GetField("innerValue", BindingFlags.Instance | BindingFlags.NonPublic);
        }

        public void Run(string command, int value)
        {
            var method = this.typeBlackBoxInteger
                .GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                .First(m => m.Name.Equals(command));

            method.Invoke(this.instanceBlackBoxInteger, new object[] { value });
            
            Console.WriteLine(this.fieldBlackBoxInteger.GetValue(this.instanceBlackBoxInteger).ToString());
        }
    }
}
