using System;

namespace Parallelepiped
{
    class Parallelepiped
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var top = "+" + new string('~', n - 2) + "+" + new string('.', 2 * n + 1);
            var bottom = new string('.', 2 * n + 1) + "+" + new string('~', n - 2) + "+";

            Console.WriteLine(top);

            for (int i = 0; i < 2 * n + 1; i++)
            {
                var topPart = "|" + new string('.', i) + "\\" + new string('~', n - 2) + "\\" + new string('.', 2 * n - i);
                Console.WriteLine(topPart);
            }

            for (int i = 0; i < 2 * n + 1; i++)
            {
                var bottomPart = new string('.', i) + "\\" + new string('.', 2 * n - i) + "|" + new string('~', n - 2) + "|";
                Console.WriteLine(bottomPart);
            }

            Console.WriteLine(bottom);
        }
    }
}
