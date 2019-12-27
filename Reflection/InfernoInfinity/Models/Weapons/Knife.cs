namespace OOP.Reflection.InfernoInfinity.Models.Weapons
{
    using OOP.Reflection.InfernoInfinity.Enums;

    public class Knife : Weapon
    {
        private const int BaseMinDamage = 3;
        private const int BaseMaxDamage = 4;
        private const int BaseSockets = 2;

        public Knife(string name, Rarity rarity)
            : base(name, BaseMinDamage, BaseMaxDamage, BaseSockets, rarity)
        {
        }
    }
}
