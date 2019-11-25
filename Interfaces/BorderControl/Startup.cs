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
                    var memberType = inputArgs[0];

                    switch (memberType.ToLower())
                    {
                        case "robot":
                            var model = inputArgs[1];
                            var robotId = inputArgs[2];
                            borderControl.AddRobot(model, robotId);
                            break;
                        case "citizen":
                            var citizenName = inputArgs[1];
                            var age = int.Parse(inputArgs[2]);
                            var citizenId = inputArgs[3];
                            var citizenBirthdate = inputArgs[4];
                            borderControl.AddCitizen(citizenName, age, citizenId, citizenBirthdate);
                            break;
                        case "pet":
                            var petName = inputArgs[1];
                            var petBirthdate = inputArgs[2];
                            borderControl.AddPet(petName, petBirthdate);
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

            var matchBirthYear = Console.ReadLine();
            Console.WriteLine(borderControl.GetBirthdatesByYear(matchBirthYear));
        }
    }
}
