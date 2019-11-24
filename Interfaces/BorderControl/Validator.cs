namespace OOP.Interfaces.BorderControl
{
    using System;
    using System.Linq;

    public static class Validator
    {
        public static void ValidateNotNull(string value, string type)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{type} cannot be null");
            }
        }

        public static void ValidateOnlyDigits(string number, string type)
        {
            if (number.Any(x => char.IsLetter(x)) || number.Any(x => char.IsWhiteSpace(x)))
            {
                throw new ArgumentException($"Invalid {type}!");
            }
        }
    }
}
