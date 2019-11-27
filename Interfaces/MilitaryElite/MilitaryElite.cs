namespace OOP.Interfaces.MilitaryElite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using OOP.Interfaces.MilitaryElite.Models;

    public class MilitaryElite
    {
        private List<Soldier> soldiers;

        public MilitaryElite()
        {
            this.soldiers = new List<Soldier>();
        }

        public void AddPrivate(int id, string firstName, string lastName, decimal salary)
        {
            var @private = new Private(id, firstName, lastName, salary);
            this.soldiers.Add(@private);
        }

        public void AddSpy(int id, string firstName, string lastName, int codeNumber)
        {
            var spy = new Spy(id, firstName, lastName, codeNumber);
            this.soldiers.Add(spy);
        }

        public void AddLieutenantGeneral(int id, string firstName, string lastName, decimal salary, params int[] privatesIds)
        {
            var lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary);

            if (privatesIds.Length > 0)
            {
                foreach (var privateId in privatesIds)
                {
                    lieutenantGeneral.AddPrivate(this.soldiers
                        .Select(x => x as Private)
                        .ToList()
                        .FirstOrDefault(x => x.Id == privateId));
                }
            }

            this.soldiers.Add(lieutenantGeneral);
        }

        public void AddEnginees(int id, string firstName, string lastName, decimal salary, string corps, params string[] repairs)
        {
            var engineer = new Engineer(id, firstName, lastName, salary, corps);

            if (repairs.Length > 0)
            {
                for (int i = 0; i < repairs.Length; i += 2)
                {
                    string partName = repairs[i];
                    int hoursWorked = int.Parse(repairs[i + 1]);

                    engineer.AddRepair(partName, hoursWorked);
                }
            }

            this.soldiers.Add(engineer);
        }

        public void AddCommando(int id, string firstName, string lastName, decimal salary, string corps, params string[] missions)
        {
            var commando = new Commando(id, firstName, lastName, salary, corps);

            if (missions.Length > 0)
            {
                for (int i = 0; i < missions.Length; i += 2)
                {
                    try
                    {
                        string codeName = missions[i];
                        string state = missions[i + 1];

                        commando.AddMission(codeName, state);
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }

            this.soldiers.Add(commando);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            this.soldiers.ForEach(x => sb.AppendLine(x.ToString()));

            return sb.ToString().TrimEnd();
        }
    }
}
