namespace OOP.Events.KingsGambit.Models
{
    using System;
    using OOP.Events.KingsGambit.Contracts;

    public abstract class Soldier : IPerson
    {
        public Soldier(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public abstract void KingIsAttacked(object sender, EventArgs args);
    }
}
