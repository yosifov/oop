namespace OOP.Events.KingsGambit.Contracts
{
    using OOP.Events.KingsGambit.Models;

    public interface IKingdomRepository
    {
        void AddKing(string kingName);

        void AddSoldier(Soldier soldier);

        void AttackKing();

        void KillSoldier(string name);
    }
}
