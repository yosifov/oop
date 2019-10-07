namespace OOP.Encapsulation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void ExecuteSortPersonsByNameAndAge()
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
                persons.Add(person);
            }

            persons.OrderBy(p => p.FirstName)
                   .ThenBy(p => p.Age)
                   .ToList()
                   .ForEach(p => Console.WriteLine(p.ToString()));
        }

        public static void ExecuteSalaryIncrease()
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();

                var person = new Person(
                    cmdArgs[0],
                    cmdArgs[1],
                    int.Parse(cmdArgs[2]),
                    decimal.Parse(cmdArgs[3]));

                persons.Add(person);
            }

            var parcentage = decimal.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(parcentage));
            persons.ForEach(p => Console.WriteLine(p.ToString()));
        }

        public static void ExecuteFirstAndReserveTeam()
        {
            var team = new Team("My Team");

            int numberOfPlayers = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPlayers; i++)
            {
                var currentPlayer = Console.ReadLine().Split();
                string playerFirstName = currentPlayer[0];
                string playerLastName = currentPlayer[1];
                int playerAge = int.Parse(currentPlayer[2]);

                team.AddPlayer(new Person(playerFirstName, playerLastName, playerAge));
            }

            Console.WriteLine(team);
        }
    }
}