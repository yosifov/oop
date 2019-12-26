namespace OOP.Interfaces.BorderControl
{
    using System;

    public class Startup : IService
    {
        public void Execute()
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

        public static void ExecuteFoodShortage()
        {
            var borderControl = new BorderControl();

            var personsNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < personsNum; i++)
            {
                var input = Console.ReadLine();

                try
                {
                    var inputArgs = input.Split();

                    switch (inputArgs.Length)
                    {
                        case 4:
                            var citizenName = inputArgs[0];
                            var age = int.Parse(inputArgs[1]);
                            var citizenId = inputArgs[2];
                            var citizenBirthdate = inputArgs[3];
                            borderControl.AddCitizen(citizenName, age, citizenId, citizenBirthdate);
                            break;
                        case 3:
                            var rebelName = inputArgs[0];
                            var rebelAge = int.Parse(inputArgs[1]);
                            var rebelGroup = inputArgs[2];
                            borderControl.AddRebel(rebelName, rebelAge, rebelGroup);
                            break;
                        default:
                            throw new ArgumentException("Invalid input!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            var currentPersonName = Console.ReadLine();

            while (currentPersonName != "End")
            {
                borderControl.BuyFrom(currentPersonName);

                currentPersonName = Console.ReadLine();
            }

            Console.WriteLine(borderControl.GetTotalFoodPurchased());
        }
    }
}
