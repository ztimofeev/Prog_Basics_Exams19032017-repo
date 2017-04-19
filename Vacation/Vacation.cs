using System;

namespace Vacation
{
    class Vacation
    {
        static void Main()
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();

            var destination = "";
            var accommodition = "";

            if (budget <= 1000)
            {
                accommodition = "Camp";
                if (season == "summer")
                {
                    budget = budget * 0.65;
                    destination = "Alaska";
                }
                else
                {
                    budget = budget * 0.45;
                    destination = "Morocco";
                }
            }
            else if (budget <= 3000)
            {
                accommodition = "Hut";
                if (season == "summer")
                {
                    budget = budget * 0.80;
                    destination = "Alaska";
                }
                else
                {
                    budget = budget * 0.60;
                    destination = "Morocco";
                }
            }
            else
            {
                accommodition = "Hotel";
                budget = budget * 0.90;
                if (season == "summer")
                {
                    destination = "Alaska";
                }
                else
                {
                    destination = "Morocco";
                }
            }

            Console.WriteLine("{0} - {1} - {2:f2}", destination, accommodition, budget);
        }
    }
}
