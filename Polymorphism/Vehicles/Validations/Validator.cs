namespace OOP.Polymorphism.Vehicles.Validations
{
    using System;

    public static class Validator
    {
        public static void ValidateNegative(double number, string type)
        {
            if (number < 0)
            {
                throw new ArgumentException($"{type} must be a positive number");
            }
        }
    }
}
