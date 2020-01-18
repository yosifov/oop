namespace OOP.Events.KingsGambit.Models
{
    using System;
    using OOP.Events.KingsGambit.Contracts;

    public class King : IPerson
    {
        public King(string name)
        {
            this.Name = name;
        }

        public event EventHandler UnderAttack;

        public string Name { get; private set; }

        public void Attack(object sender, EventArgs args)
        {
            Console.WriteLine($"King {this.Name} is under attack!");
            this.UnderAttack?.Invoke(this, EventArgs.Empty);
        }
    }
}
