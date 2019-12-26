namespace OOP.Reflection.BarracksWars.Contracts
{
    public interface IRepository
    {
        string Statistics { get; }

        void AddUnit(IUnit unit);

        string RemoveUnit(string unitType);
    }
}
