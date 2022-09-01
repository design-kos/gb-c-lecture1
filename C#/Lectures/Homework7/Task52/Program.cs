// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


using System;

namespace Homeworks
{
    class Program
    {

        static int[,] ArrayFilling(int m, int n)
        {
            int[,] array = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = new Random().Next(0, 10);
                }
            }
            return array;
        }

        static void PrintArray(int[,] array, int m, int n)
        {

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Укажите количество строк двумерного массива: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Укажите количество столбцов двумерного массива: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] array = ArrayFilling(m, n);
            PrintArray(array, m, n);

            for (int i = 0; i < n; i++)
            {
                double sumNumbers = 0;
                for (int j = 0; j < m; j++)
                {
                    sumNumbers += array[j, i];
                }
                double average = Math.Round(sumNumbers / m, 1);
                Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {average}");
            }
        }
    }
}