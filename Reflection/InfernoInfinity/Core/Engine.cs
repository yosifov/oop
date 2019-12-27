namespace OOP.Reflection.InfernoInfinity.Core
{
    using System;
    using OOP.Reflection.InfernoInfinity.Contracts;

    public class Engine
    {
        private ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            try
            {
                while (true)
                {
                    string[] userInput = Console.ReadLine().Trim()
                        .Split(";");

                    if (userInput.Length < 1 || userInput.Length > 4)
                    {
                        throw new ArgumentException("Invalid user input");
                    }

                    string commandName = userInput[0];

                    string result = this.commandInterpreter.InterpretCommand(userInput, commandName).Execute();

                    Console.WriteLine(result);

                    if (commandName.ToLower() == "end")
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
