// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


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
                    array[i, j] = Math.Round(new Random().NextDouble() * 15 - 10, 1);
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

            double[,] array = ArrayFilling(m, n);
            PrintArray(array, m, n);

            Console.WriteLine("Укажите номер строки искомой позиции: ");
            int rowNumber = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine("Укажите номер столбца искомой позиции: ");
            int columnNumber = Convert.ToInt32(Console.ReadLine()) - 1;

            if (rowNumber > m || rowNumber == -1 || columnNumber > n || columnNumber == -1)
                Console.WriteLine("Такого элемента нет");
            else
            {
                var resultElement = array.GetValue(rowNumber, columnNumber);
                Console.WriteLine($"В строке {rowNumber} и столбце {columnNumber} находится элемент со значением {resultElement}");
            }
        }
    }
}