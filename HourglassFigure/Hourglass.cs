using System;

namespace HourglassFigure
{
    class Hourglass
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var topBottom = new string('*', 2 * n + 1);
            var firstLine = "." + "*" + new string(' ', 2 * n - 3) + "*" + ".";

            Console.WriteLine(topBottom);
            Console.WriteLine(firstLine);

            for (int i = 0; i < n - 2; i++)
            {
                var topCone = new string('.', 2 + i) + "*" + new string('@', (2 * n - 5) - 2 * i) + "*" + new string('.', 2 + i);
                Console.WriteLine(topCone);
            }
            Console.WriteLine(new string('.', (2 * n + 1) / 2) + "*" + new string('.', (2 * n + 1) / 2));
            for (int i = n - 3; i >= 0; i--)
            {
                var bottomCone = new string('.', 2 + i) + "*" + new string(' ', n - 3 - i) + "@" + new string(' ', n - 3 - i) + "*" + new string('.', 2 + i);
                Console.WriteLine(bottomCone);
            }
            Console.WriteLine("." + "*" + new string('@', 2 * n - 3) + "*" + ".");
            Console.WriteLine(topBottom);
        }
    }
}
