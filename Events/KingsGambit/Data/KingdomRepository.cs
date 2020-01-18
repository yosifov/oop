namespace OOP.Events.KingsGambit.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using OOP.Events.KingsGambit.Contracts;
    using OOP.Events.KingsGambit.Models;

    public class KingdomRepository : IKingdomRepository
    {
        private IList<Soldier> soldiers;
        private King king;

        public KingdomRepository()
        {
            this.soldiers = new List<Soldier>();
            this.king = null;
        }

        public void AddKing(string name)
        {
            this.king = new King(name);
        }

        public void AddSoldier(Soldier soldier)
        {
            this.soldiers.Add(soldier);

            if (this.king != null)
            {
                this.king.UnderAttack += soldier.KingIsAttacked;
            }
        }

        public void AttackKing()
        {
            if (this.king != null)
            {
                this.king.Attack(this.king, EventArgs.Empty);
            }
        }

        public void KillSoldier(string soldierName)
        {
            var soldierToRemove = this.soldiers.FirstOrDefault(x => x.Name == soldierName);
            this.soldiers.Remove(soldierToRemove);
            this.king.UnderAttack -= soldierToRemove.KingIsAttacked;
        }
    }
}
