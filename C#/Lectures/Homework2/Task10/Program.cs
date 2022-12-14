// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

using System;

namespace Homeworks
{
    class Program
    {
        static int FindSecondDigitOfNumber(int N)
        {
            int secondDigitOfNumber = N / 10 % 10;
            return secondDigitOfNumber;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Введите трехзначное число: ");
            int N = Convert.ToInt32(Console.ReadLine());

            while (N > 0)
            {
                if (N < 99)
                {
                    Console.WriteLine("Введите ТРЕХЗНАЧНОЕ число: ");
                    N = Convert.ToInt32(Console.ReadLine());
                }
                else if (N > 999)
                {
                    Console.WriteLine("Введите ТРЕХЗНАЧНОЕ число: ");
                    N = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    int secondDigit = FindSecondDigitOfNumber(N);
                    Console.WriteLine($"Вторая цифры введенного числа - {secondDigit}");
                    break;
                }
            }
        }
    }
}