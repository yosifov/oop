namespace OOP.Interfaces.MilitaryElite.Interfaces
{
    using System.Collections.Generic;
    using OOP.Interfaces.MilitaryElite.Models;

    public interface ICommando
    {
        IReadOnlyCollection<Mission> Missions { get; }

        void CompleteMission(string missionCodeName);
    }
}
