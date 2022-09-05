// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


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

        static void MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
        {
            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    int sum = 0;
                    for (int k = 0; k < firstMatrix.GetLength(1); k++)
                    {
                        sum += firstMatrix[i, k] * secondMatrix[k, j];
                    }
                    resultMatrix[i, j] = sum;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Укажите количество строк для 1-й матрицы: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Укажите количество столбцов для 1-й матрицы и строк для 2-й: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Укажите количество столбцов для 2-й матрицы: ");
            int p = Convert.ToInt32(Console.ReadLine());

            int[,] firstMatrix = ArrayFilling(m, n);
            Console.WriteLine("Первая матрица: ");
            PrintArray(firstMatrix, m, n);

            Console.WriteLine();

            int[,] secondMatrix = ArrayFilling(n, p);
            Console.WriteLine("Вторая матрица: ");
            PrintArray(secondMatrix, n, p);

            Console.WriteLine();

            int[,] resultMatrix = new int[m, p];
            MatrixMultiplication(firstMatrix, secondMatrix, resultMatrix);
            Console.WriteLine("Произведение матриц: ");
            PrintArray(resultMatrix, m, p);

        }
    }
}