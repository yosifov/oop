namespace OOP.Interfaces.MilitaryElite
{
    using System;

    public static class Validator
    {
        public static void ValidateNotNull(string value, string type)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{type} cannot be null");
            }
        }
    }
}
