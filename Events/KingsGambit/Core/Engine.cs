namespace OOP.Events.KingsGambit.Core
{
    using System;

    using OOP.Events.KingsGambit.Contracts;
    using OOP.Events.KingsGambit.Data;
    using OOP.Events.KingsGambit.Models;

    public class Engine : IRunnable
    {
        private IKingdomRepository repository;

        public Engine()
        {
            this.repository = new KingdomRepository();
        }

        public void Run()
        {
            string kingName = Console.ReadLine();

            this.repository.AddKing(kingName);

            string[] royalGuards = Console.ReadLine().Split();

            foreach (var royalGuard in royalGuards)
            {
                this.repository.AddSoldier(new RoyalGuard(royalGuard));
            }

            string[] footmen = Console.ReadLine().Split();

            foreach (var footman in footmen)
            {
                this.repository.AddSoldier(new Footman(footman));
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                var commandArgs = command.Split();
                string commandType = commandArgs[0];
                string soldierName = commandArgs[1];

                switch (commandType)
                {
                    case "Attack":
                        this.repository.AttackKing();
                        break;
                    case "Kill":
                        this.repository.KillSoldier(soldierName);
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
