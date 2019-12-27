namespace OOP.Reflection.InfernoInfinity.Models.Gems
{
    using OOP.Reflection.InfernoInfinity.Enums;

    public class Amethyst : Gem
    {
        private const int BaseStrength = 2;
        private const int BaseAgility = 8;
        private const int BaseVitality = 4;

        public Amethyst(Clarity clarity)
            : base(BaseStrength, BaseAgility, BaseVitality, clarity)
        {
        }
    }
}
