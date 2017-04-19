using System;

namespace FamilyBills
{
    class FamilyBills
    {
        static void Main()
        {
            var months = int.Parse(Console.ReadLine());

            double electricity = 0;

            for (int i = 0; i < months; i++)
            {
                electricity += double.Parse(Console.ReadLine());
            }

            var totalSpend = electricity + months * 35;
            var otherSpends = totalSpend * 1.20;

            Console.WriteLine("Electricity: {0:f2} lv", electricity);
            Console.WriteLine("Water: {0:f2} lv", months * 20);
            Console.WriteLine("Internet: {0:f2} lv", months * 15);
            Console.WriteLine("Other: {0:f2} lv", otherSpends);
            Console.WriteLine("Average: {0:f2} lv", (totalSpend + otherSpends) / months);
        }
    }
}
