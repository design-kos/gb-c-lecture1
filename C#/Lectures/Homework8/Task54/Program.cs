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

        static int[,] OrderElementsInRow(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(1) - 1; k++)
                    {
                        if (array[i, k] < array[i, k + 1])
                        {
                            int temp = array[i, k + 1];
                            array[i, k + 1] = array[i, k];
                            array[i, k] = temp;
                        }
                    }
                }
            }
            return array;
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
            PrintArray(OrderElementsInRow(array), m, n);
        }
    }
}