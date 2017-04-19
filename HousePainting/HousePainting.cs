using System;

namespace HousePainting
{
    class HousePainting
    {
        static void Main()
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var frontSide = (x * x - 2 * 1.2) + x * x;
            var sideWall = 2 * (x * y - (1.50 * 1.50));

            var greenPart = (frontSide + sideWall) / 3.4;
            var redPart = (2 * (y * x + x * h / 2)) / 4.3;

            Console.WriteLine("{0:f2}", greenPart);
            Console.WriteLine("{0:f2}", redPart);
        }
    }
}
