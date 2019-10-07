namespace OOP.Encapsulation
{
    using System;
    using System.Collections.Generic;

    public class Team
    {
        private string name;

        private List<Person> firstTeam;

        private List<Person> reserveTeam;

        public Team(string name)
        {
            this.Name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }

        public IReadOnlyList<Person> FirstTeam
        {
            get => this.firstTeam.AsReadOnly();
        }

        public IReadOnlyList<Person> ReserveTeam
        {
            get => this.reserveTeam.AsReadOnly();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Team name should be more than 2 characters.");
                }

                this.name = value;
            }
        }

        public void AddPlayer(Person player)
        {
            if (player.Age < 40)
            {
                this.firstTeam.Add(player);
            }
            else
            {
                this.reserveTeam.Add(player);
            }
        }

        public override string ToString()
        {
            return $"{nameof(this.FirstTeam)} has {this.FirstTeam.Count} players. \n" +
                $"{nameof(this.ReserveTeam)} has {this.ReserveTeam.Count} players.";
        }
    }
}
