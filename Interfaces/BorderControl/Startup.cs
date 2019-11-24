namespace OOP.Interfaces.BorderControl
{
    using System;

    public class Startup
    {
        public static void Execute()
        {
            var borderControl = new BorderControl();

            var input = Console.ReadLine();

            while (input != "End")
            {
                try
                {
                    var inputArgs = input.Split();

                    switch (inputArgs.Length)
                    {
                        case 2:
                            var model = inputArgs[0];
                            var robotId = inputArgs[1];
                            borderControl.AddRobot(model, robotId);
                            break;
                        case 3:
                            var name = inputArgs[0];
                            var age = int.Parse(inputArgs[1]);
                            var citizenId = inputArgs[2];
                            borderControl.AddCitizen(name, age, citizenId);
                            break;
                        default:
                            throw new ArgumentException("Invalid input!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine();
            }

            var matchId = Console.ReadLine();
            borderControl.AddDetainedIds(matchId);
            Console.WriteLine(borderControl.GetDetainedIds(matchId));
        }
    }
}
