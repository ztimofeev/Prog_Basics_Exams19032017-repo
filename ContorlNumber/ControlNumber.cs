using System;

namespace ContorlNumber
{
    class ControlNumber
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var controlNumber = int.Parse(Console.ReadLine());

            var sum = 0;
            var count = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = m; j > 0; j--)
                {
                    sum += i * 2 + j * 3;
                    count++;
                    if (sum >= controlNumber)
                    {
                        Console.WriteLine($"{count} moves");
                        Console.WriteLine($"Score: {sum} >= {controlNumber}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{count} moves");
        }
    }
}
