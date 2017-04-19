using System;

namespace Cups
{
    class Cups
    {
        static void Main()
        {
            var cupsCount = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var workingDays = int.Parse(Console.ReadLine());

            double totalCups = (workers * workingDays * 8) / 5;
            totalCups = Math.Truncate(totalCups);

            double diff = Math.Abs(totalCups - cupsCount);

            if (cupsCount <= totalCups)
            {

                Console.WriteLine("{0:f2} extra money", diff * 4.20);
            }
            else
            {
                Console.WriteLine("Losses: {0:f2}", diff * 4.20);
            }
        }
    }
}
