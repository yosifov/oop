namespace OOP.Reflection.BarracksWars.Core.Commands
{
    using OOP.Reflection.BarracksWars.Contracts;

    public class Retire : Command
    {
        public Retire(string[] data, IRepository repository, IUnitFactory unitFactory) 
            : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            string unitType = this.Data[1];
            string output = this.Repository.RemoveUnit(unitType);
            return output;
        }
    }
}
