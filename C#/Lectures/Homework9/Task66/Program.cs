// Задайте значения M и N. Напишите программу, которая найдёт сумму чётных чисел натуральных элементов в промежутке от M до N.


using System;

namespace Homeworks
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число M: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            if (m > n)
            {
                for (int i = n; i <= m; i++)
                {
                    Console.Write($"{i} ");

                    if (i % 2 == 0)
                    {
                        sum = sum + i;
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"Сумма четных натуральных числе в промежутке от {n} до {m} равна {sum}");
            }
            else
            {
                for (int i = m; i <= n; i++)
                {
                    Console.Write($"{i} ");

                    if (i % 2 == 0)
                    {
                        sum = sum + i;
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"Сумма четных натуральных числе в промежутке от {m} до {n} равна {sum}");
            }

        }
    }
}