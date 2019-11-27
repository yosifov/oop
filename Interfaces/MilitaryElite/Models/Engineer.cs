namespace OOP.Interfaces.MilitaryElite.Models
{
    using System.Collections.Generic;
    using System.Text;
    using OOP.Interfaces.MilitaryElite.Interfaces;

    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private List<Repair> repairs;

        public Engineer(int id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.repairs = new List<Repair>();
        }

        public IReadOnlyCollection<Repair> Repairs { get; }

        public void AddRepair(string partName, int hoursWorked)
        {
            var repair = new Repair(partName, hoursWorked);
            this.repairs.Add(repair);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Repairs:");
            this.repairs.ForEach(x => sb.AppendLine($"  {x.ToString()}"));
            
            return sb.ToString().TrimEnd();
        }
    }
}
