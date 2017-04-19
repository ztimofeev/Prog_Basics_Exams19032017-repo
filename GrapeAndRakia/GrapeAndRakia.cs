using System;

namespace GrapeAndRakia
{
    class GrapeAndRakia
    {
        static void Main()
        {
            var area = double.Parse(Console.ReadLine());
            var grapeFromSqMeter = double.Parse(Console.ReadLine());
            var loss = double.Parse(Console.ReadLine());

            var totalGrape = area * grapeFromSqMeter - loss;
            var grapeForSale = totalGrape * 0.55;
            var rakia = (totalGrape - grapeForSale) / 7.5;

            Console.WriteLine("{0:f2}", rakia * 9.80);
            Console.WriteLine("{0:f2}", grapeForSale * 1.50);
        }
    }
}
