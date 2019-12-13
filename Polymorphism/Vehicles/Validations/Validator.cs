namespace OOP.Polymorphism.Vehicles.Validations
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class Validator
    {
        public static void ValidateNegative(double number, string type)
        {
            if (number < 0)
            {
                throw new ArgumentException($"{type} cannot be negative");
            }
        }
    }
}
