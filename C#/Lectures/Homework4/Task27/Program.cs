// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


using System;

namespace Homeworks
{
    class Program
    {
        static int SumDigits(int N)
        {
            int result = 0;
            while (N > 0)
            {
                result = result + N % 10;
                N = N / 10;
            }
            return result;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Введите число, чтобы узнать сумму его цифр: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int sumDigits = SumDigits(N);
            Console.WriteLine($"Сумма цифр числа {N} = {sumDigits}");
        }
    }
}