// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


using System;

namespace Homeworks
{
    class Program
    {

        static double[,] ArrayFilling(int m, int n)
        {
            double[,] array = new double[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = new Random().NextDouble() * 15 - 10;
                }
            }
            return array;
        }

        static void PrintArray(double[,] array, int m, int n)
        {

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    double element = Math.Round(array[i, j], 1);
                    Console.Write($"{element}\t");
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

            double[,] array = ArrayFilling(m,n);
            PrintArray(array, m, n);
        }
    }
}