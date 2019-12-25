namespace OOP.Reflection.HarvestingFields
{
    using System;

    public class Startup
    {
        public static void Execute()
        {
            var harvestingFieldsTest = new HarvestingFieldsTest();

            string input = Console.ReadLine();

            while (input.ToLower() != "harvest")
            {
                harvestingFieldsTest.Run(input);

                input = Console.ReadLine();
            }
        }
    }
}
