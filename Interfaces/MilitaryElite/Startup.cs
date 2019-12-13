namespace OOP.Interfaces.MilitaryElite
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Execute()
        {
            var militaryElite = new MilitaryElite();

            var input = Console.ReadLine();

            while (input != "End")
            {
                string[] soldierArgs = input.Split();

                string soldierType = soldierArgs[0];
                int soldierId = int.Parse(soldierArgs[1]);
                string soldierFirstName = soldierArgs[2];
                string soldierLastName = soldierArgs[3];

                switch (soldierType)
                {
                    case "Private":
                        decimal privateSalary = decimal.Parse(soldierArgs[4]);

                        militaryElite.AddPrivate(soldierId,
                            soldierFirstName,
                            soldierLastName,
                            privateSalary);
                        break;
                    case "Spy":
                        int spyCodeNumber = int.Parse(soldierArgs[4]);

                        militaryElite.AddSpy(soldierId,
                            soldierFirstName,
                            soldierLastName,
                            spyCodeNumber);
                        break;
                    case "LieutenantGeneral":
                        decimal lieutenantSalary = decimal.Parse(soldierArgs[4]);
                        int[] privates = soldierArgs.Skip(5).Select(int.Parse).ToArray();

                        militaryElite.AddLieutenantGeneral(soldierId,
                            soldierFirstName,
                            soldierLastName,
                            lieutenantSalary,
                            privates);
                        break;
                    case "Engineer":
                        decimal engineerSalary = decimal.Parse(soldierArgs[4]);
                        string engineerCorps = soldierArgs[5];
                        string[] repairs = soldierArgs.Skip(6).ToArray();

                        try
                        {
                            militaryElite.AddEnginees(soldierId,
                                soldierFirstName,
                                soldierLastName,
                                engineerSalary,
                                engineerCorps,
                                repairs);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "Commando":
                        decimal commandoSalary = decimal.Parse(soldierArgs[4]);
                        string commandoCorps = soldierArgs[5];
                        string[] missions = soldierArgs.Skip(6).ToArray();

                        try
                        {
                            militaryElite.AddCommando(soldierId,
                                soldierFirstName,
                                soldierLastName,
                                commandoSalary,
                                commandoCorps,
                                missions);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(militaryElite);
        }
    }
}
