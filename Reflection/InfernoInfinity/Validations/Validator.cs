namespace OOP.Reflection.InfernoInfinity.Validations
{
    using System;

    public static class Validator
    {
        public static void ValidateNullOrEmpty(string value, string type)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"Invalid {type}");
            }
        }

        public static void ValidateNegative(int value, string type)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Invalid {type}");
            }
        }
    }
}
