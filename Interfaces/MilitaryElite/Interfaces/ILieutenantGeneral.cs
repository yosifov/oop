namespace OOP.Interfaces.MilitaryElite.Interfaces
{
    using System.Collections.Generic;
    using OOP.Interfaces.MilitaryElite.Models;

    public interface ILieutenantGeneral
    {
        IReadOnlyCollection<Private> Privates { get; }
    }
}
