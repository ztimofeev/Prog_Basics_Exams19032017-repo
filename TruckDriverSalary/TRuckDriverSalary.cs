using System;

namespace TruckDriverSalary
{
    class TruckDriverSalary
    {
        static void Main()
        {
            var season = Console.ReadLine().ToLower();
            var kilometers = double.Parse(Console.ReadLine());

            double salary = 1;

            if (kilometers <= 5000)
            {
                if (season == "spring" || season == "autumn")
                {
                    salary = kilometers * 0.75 * 4 * 0.90;
                }
                else if (season == "summer")
                {
                    salary = kilometers * 0.90 * 4 * 0.90;
                }
                else if (season == "winter")
                {
                    salary = kilometers * 1.05 * 4 * 0.90;
                }
            }
            else if (kilometers <= 10000)
            {
                if (season == "spring" || season == "autumn")
                {
                    salary = kilometers * 0.95 * 4 * 0.90;
                }
                else if (season == "summer")
                {
                    salary = kilometers * 1.10 * 4 * 0.90;
                }
                else if (season == "winter")
                {
                    salary = kilometers * 1.25 * 4 * 0.90;
                }
            }
            else
            {
                salary = kilometers * 1.45 * 4 * 0.90;
            }

            Console.WriteLine("{0:f2}", salary);
        }
    }
}
