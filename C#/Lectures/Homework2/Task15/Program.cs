// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

using System;

namespace Homeworks
{
    class Program
    {
        static int IsTheDayOfTheWeekAHoliday(int N)
        {
            int scenario = 0;
            if (N == 6 || N == 7)
            {
                scenario = 1;
            }
            else if (N < 1 || N > 7)
            {
                scenario = 2;
            }
            else
            {
                scenario = 3;
            }
            return scenario;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Введите номер дня недели: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int scenario = IsTheDayOfTheWeekAHoliday(N);

            if (scenario == 1)
            {
                Console.WriteLine("Этот день выходной");
            }
            if (scenario == 2)
            {
                Console.WriteLine("Это не день недели");
            }
            if (scenario == 3)
            {
                Console.WriteLine("Этот день не выходной");
            }
        }
    }
}