// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

using System;

namespace Homeworks
{
    class Program
    {
        static int FindThirdDigitOfNumber(int N)
        {
            int thirdDigitOfNumber = -1;

            if (N < 100)
            {
                thirdDigitOfNumber = -1;
            }
            else
            {
                while (N > 999)
                {
                    N /= 10;
                }
                thirdDigitOfNumber = N % 10;
            }
            return thirdDigitOfNumber;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int thirdDigit = FindThirdDigitOfNumber(N);

            if (thirdDigit == -1)
            {
                Console.WriteLine("У введенного числа нет третьей цифры");
            }
            else
            {
                Console.WriteLine($"Третья цифры введенного числа - {thirdDigit}");
            }
        }
    }
}