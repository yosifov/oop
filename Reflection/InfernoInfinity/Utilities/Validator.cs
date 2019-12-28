namespace OOP.Reflection.InfernoInfinity.Utilities
{
    using System;

    public static class Validator
    {
        public static void ValidateNullOrEmpty(string value, string objectName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"Invalid {objectName}");
            }
        }

        public static void ValidateNegative(int value, string objectName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Invalid {objectName}");
            }
        }
    }
}
