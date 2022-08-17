// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


using System;

namespace Homeworks
{
    class Program
    {
        static int ChekingForPalindrome(int N)
        {
            int num = 0;
            int numTmp = N;
            int rev = 0;
            int scenario = 0;
            int firstDigit = N;

            while (firstDigit >= 10)
            {
                firstDigit = (firstDigit - (firstDigit % 10)) / 10;
            }

            if (firstDigit == 0)
            {
                scenario = 0;
            }
            else
            {
                while (N > 0)
                {
                    num = N % 10;
                    rev = rev * 10 + num;
                    N = N / 10;
                }
                if (numTmp == rev)
                {
                    scenario = 1;
                }
                else
                {
                    scenario = 2;
                }
            }
            return scenario;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Введите число: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int scenario = ChekingForPalindrome(N);

            while (N >= 0)
            {
                if (scenario == 0)
                {
                    Console.WriteLine("ОШИБКА. Введите натуральное число");
                }
                else if (scenario == 1)
                {
                    Console.WriteLine("Введенное число является палиндромом");
                    break;
                }
                else if (scenario == 2)
                {
                    Console.WriteLine("Введенное число не является палиндромом");
                    break;
                }
                N = Convert.ToInt32(Console.ReadLine());
                scenario = ChekingForPalindrome(N);
            }
        }
    }
}