namespace OOP.Reflection.InfernoInfinity.Models.Gems
{
    using OOP.Reflection.InfernoInfinity.Enums;

    public class Emerald : Gem
    {
        private const int BaseStrength = 1;
        private const int BaseAgility = 4;
        private const int BaseVitality = 9;

        public Emerald(Clarity clarity)
            : base(BaseStrength, BaseAgility, BaseVitality, clarity)
        {
        }
    }
}
