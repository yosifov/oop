namespace OOP.Interfaces.MilitaryElite.Models
{
    using System.Collections.Generic;
    using System.Text;
    using OOP.Interfaces.MilitaryElite.Interfaces;

    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private List<Private> privates;

        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName, salary)
        {
            this.privates = new List<Private>();
        }

        public IReadOnlyCollection<Private> Privates { get; }

        public void AddPrivate(Private privateSoldier)
        {
            this.privates.Add(privateSoldier);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");
            this.privates.ForEach(x => sb.AppendLine($"  {x.ToString()}"));
            return sb.ToString().TrimEnd();
        }
    }
}
