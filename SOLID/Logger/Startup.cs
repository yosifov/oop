namespace OOP.SOLID.Logger
{
    using System;
    using OOP.SOLID.Logger.Core;

    public class Startup
    {
        private ICommandInterpreter commandInterpreter;

        public Startup()
        {
            this.commandInterpreter = new CommandInterpreter();
        }

        public void Execute()
        {
            int numberOfAppenders = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfAppenders; i++)
            {
                try
                {
                    string[] appenderArgs = Console.ReadLine()
                    .Split();

                    this.commandInterpreter.AddAppender(appenderArgs);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                try
                {
                    string[] logArgs = command.Split("|");

                    this.commandInterpreter.AddMessage(logArgs);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(this.commandInterpreter);
        }
    }
}
