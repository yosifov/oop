namespace OOP.Inheritance.Mankind
{
    using System;

    public class Startup : IService
    {
        public void Execute()
        {
            try
            {
                string[] studentArgs = Console.ReadLine()
                    .Split();
                string studentFirstName = studentArgs[0];
                string studentLastName = studentArgs[1];
                string studentFacultyNumber = studentArgs[2];

                var student = new Student(studentFirstName, studentLastName, studentFacultyNumber);

                string[] workerArgs = Console.ReadLine()
                    .Split();
                string workerFirstName = workerArgs[0];
                string workerLastName = workerArgs[1];
                decimal workerWeekSalary = decimal.Parse(workerArgs[2]);
                int workerHoursPerDay = int.Parse(workerArgs[3]);

                var worker = new Worker(workerFirstName, workerLastName, workerWeekSalary, workerHoursPerDay);
                
                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}
