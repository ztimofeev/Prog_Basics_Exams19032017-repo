using System;

namespace TrainerSalary
{
    class TrainerSalary
    {
        static void Main()
        {
            var lectures = int.Parse(Console.ReadLine());
            var budget = double.Parse(Console.ReadLine());

            double salary = budget / lectures;

            var countJelev = 0;
            var countRoyal = 0;
            var countRoli = 0;
            var countTrofon = 0;
            var countSino = 0;
            var countGuest = 0;

            for (int i = 0; i < lectures; i++)
            {
                var trainer = Console.ReadLine().ToLower();
                if (trainer == "jelev")
                {
                    countJelev += 1;
                }
                else if (trainer == "royal")
                {
                    countRoyal += 1;
                }
                else if (trainer == "roli")
                {
                    countRoli += 1;
                }
                else if (trainer == "trofon")
                {
                    countTrofon += 1;
                }
                else if (trainer == "sino")
                {
                    countSino += 1;
                }
                else
                {
                    countGuest += 1;
                }
            }

            Console.WriteLine("Jelev salary: {0:f2} lv", countJelev * salary);
            Console.WriteLine("RoYaL salary: {0:f2} lv", countRoyal * salary);
            Console.WriteLine("Roli salary: {0:f2} lv", countRoli * salary);
            Console.WriteLine("Trofon salary: {0:f2} lv", countTrofon * salary);
            Console.WriteLine("Sino salary: {0:f2} lv", countSino * salary);
            Console.WriteLine("Others salary: {0:f2} lv", countGuest * salary);
        }
    }
}
