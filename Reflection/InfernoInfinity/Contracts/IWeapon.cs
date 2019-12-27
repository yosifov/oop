namespace OOP.Reflection.InfernoInfinity.Contracts
{
    using OOP.Reflection.InfernoInfinity.Enums;

    public interface IWeapon
    {
        string Name { get; }

        int MinDamage { get; }

        int MaxDamage { get; }

        int Sockets { get; }

        Rarity WeaponRarity { get; }

        void AddGem(int gemIndex, IGem gem);

        void RemoveGem(int gemIndex);
    }
}
