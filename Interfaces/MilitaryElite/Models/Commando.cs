namespace OOP.Interfaces.MilitaryElite.Models
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using OOP.Interfaces.MilitaryElite.Interfaces;

    public class Commando : SpecialisedSoldier, ICommando
    {
        private List<Mission> missions;

        public Commando(int id, string firstName, string lastName, decimal salary, string corps) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.missions = new List<Mission>();
        }

        public IReadOnlyCollection<Mission> Missions { get; }

        public void AddMission(string codeName, string state)
        {
            var mission = new Mission(codeName, state);
            this.missions.Add(mission);
        }

        public void CompleteMission(string missionCodeName)
        {
            this.missions.Where(x => x.CodeName == missionCodeName).ToList().ForEach(y => y.State = "Finished");
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Missions:");
            this.missions.ForEach(x => sb.AppendLine($"  {x.ToString()}"));
            return sb.ToString().TrimEnd();
        }
    }
}
