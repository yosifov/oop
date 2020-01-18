namespace OOP.Events.KingsGambit.Models
{
    using System;

    public class RoyalGuard : Soldier
    {
        public RoyalGuard(string name)
            : base(name)
        {
        }

        public override void KingIsAttacked(object sender, EventArgs args)
        {
            Console.WriteLine($"Royal Guard {this.Name} is defending!");
        }
    }
}
