namespace OOP.Interfaces.Cars
{
    using System;

    public class Startup
    {
        public static void Execute()
        {
            try
            {
                ICar seat = new Seat("Leon", "Grey");
                ICar tesla = new Tesla("Model 3", "Red", 3);

                Console.WriteLine(seat.ToString());
                Console.WriteLine(tesla.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}
