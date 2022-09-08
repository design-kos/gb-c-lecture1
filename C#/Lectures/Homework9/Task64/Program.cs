// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N от большего к меньшему.


using System;

namespace Homeworks
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа M: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (m > n)
            {
                for (int i = m; i >= n; i--)
                {
                    Console.Write($"{i} ");
                }
            }
            else
            {
                for (int i = n; i >= m; i--)
                {
                    Console.Write($"{i} ");
                }
            }

        }
    }
}