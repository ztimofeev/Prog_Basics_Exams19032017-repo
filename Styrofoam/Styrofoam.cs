using System;

namespace Styrofoam
{
    class Styrofoam
    {
        static void Main()
        {
            var budget = double.Parse(Console.ReadLine());
            var houseArea = double.Parse(Console.ReadLine());
            var windowsCount = double.Parse(Console.ReadLine());
            var material = double.Parse(Console.ReadLine());
            var priceForPacket = double.Parse(Console.ReadLine());

            var totalArea = (houseArea - windowsCount * 2.40) * 1.10;
            var totalPrice = Math.Ceiling(totalArea / material) * priceForPacket;

            if (budget >= totalPrice)
            {
                Console.WriteLine("Spent: {0:f2}", totalPrice);
                Console.WriteLine("Left: {0:f2}", (budget - totalPrice));
            }
            else
            {
                Console.WriteLine("Need more: {0:f2}", (totalPrice - budget));
            }
        }
    }
}
