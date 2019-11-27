namespace OOP.Interfaces.MilitaryElite.Models
{
    using System.Text;
    using OOP.Interfaces.MilitaryElite.Interfaces;

    public class Spy : Soldier, ISpy
    {
        public Spy(int id, string firstName, string lastName, int codeNumber)
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.Append($"Code Number: {this.CodeNumber}");
            return sb.ToString();
        }
    }
}
