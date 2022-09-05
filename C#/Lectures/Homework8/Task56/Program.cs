// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


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

        static int GetRowSum(int[,] array, int i)
        {
            int rowSum = array[i, 0];
            for (int j = 1; j < array.GetLength(1); j++)
            {
                rowSum += array[i, j];
            }
            return rowSum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Укажите количество строк двумерного массива: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Укажите количество столбцов двумерного массива: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] array = ArrayFilling(m, n);
            PrintArray(array, m, n);
            Console.WriteLine();

            int minRowSum = 0;
            int rowSum = GetRowSum(array, 0);
            for (int i = 1; i < array.GetLength(0); i++)
            {
                int tempRowSum = GetRowSum(array, i);
                if (rowSum > tempRowSum)
                {
                    rowSum = tempRowSum;
                    minRowSum = i;
                }
            }
            Console.WriteLine($"Номер строки с наименьшей суммой элементов равной {rowSum} - {minRowSum + 1}");
        }
    }
}