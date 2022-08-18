// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


using System;

namespace Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите число, до которого будет создана таблица кубов: ");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Число {i} в кубе равно {i*i*i}"); 
            }
        }
    }
}