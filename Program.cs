namespace OOP
{
    using OOP.Enums;
    using System;
    using System.Linq;
    using System.Reflection;

    public class Program
    {
        public static void Main()
        {
            string course = "OOP";
            string topic = GetTopic();
            string task = GetTask(topic);

            var nameSpace = $"{course}.{topic}.{task}";

            IService startUp = GetStartService(nameSpace);
            startUp.Execute();
        }

        private static IService GetStartService(string nameSpace)
        {
            var type = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Namespace == nameSpace && t.Name == "Startup");

            return Activator.CreateInstance(type) as IService;
        }

        private static string GetTopic()
        {
            Console.WriteLine("Please select topic. Available options:");

            foreach (Topics topic in (Topics[])Enum.GetValues(typeof(Topics)))
            {
                Console.WriteLine($"({(int)topic}) {topic.ToString()}");
            }

            int userSelection;
            Enum result;

            while (true)
            {
                Console.Write("Enter your choice: ");

                try
                {
                    userSelection = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }

                if (Enum.IsDefined(typeof(Topics), userSelection))
                {
                    result = (Topics)userSelection;
                }
                else
                {
                    continue;
                }
                break;
            }

            return result.ToString();
        }

        private static string GetTask(string topic)
        {
            Type taskEnum = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(x => x.Name == $"{topic}Tasks");

            Console.WriteLine("Please select task. Available options:");

            foreach (var task in Enum.GetValues(taskEnum))
            {
                Console.WriteLine($"({(int)task}) {task}");
            }

            int userSelection;

            while (true)
            {
                Console.Write("Enter your choice: ");

                try
                {
                    userSelection = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }

                if ((taskEnum.GetEnumValues() as int[]).Contains(userSelection))
                {
                    break;
                }
                else
                {
                    continue;
                }
            }

            return taskEnum.GetEnumName(userSelection);
        }
    }
}