// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


using System;

namespace Homeworks
{
    class Program
    {

        static void Array3DFilling(int[,,] array)
        {
            int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
            int element;
            for (int i = 0; i < temp.GetLength(0); i++)
            {
                temp[i] = new Random().Next(10, 100);
                element = temp[i];
                if (i >= 1)
                {
                    for (int j = 0; j < i; j++)
                    {
                        while (temp[i] == temp[j])
                        {
                            temp[i] = new Random().Next(10, 100);
                            j = 0;
                            element = temp[i];
                        }
                        element = temp[i];
                    }
                }
            }

            int count = 0;
            for (int x = 0; x < array.GetLength(0); x++)
            {
                for (int y = 0; y < array.GetLength(1); y++)
                {
                    for (int z = 0; z < array.GetLength(2); z++)
                    {
                        array[x, y, z] = temp[count];
                        count++;
                    }
                }
            }
        }

        static void PrintArray3D(int[,,] array)
        {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int h = 0; h < array.GetLength(2); h++)
                        {
                            Console.Write(array[i, j, h]);
                            Console.Write("({0},{1},{2})\t", i, j, h);
                        }

                        Console.WriteLine();
                    }

                    Console.WriteLine();
                }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива по координате X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите длину массива по координате Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите длину массива по координате Z: ");
            int z = Convert.ToInt32(Console.ReadLine());

            int[,,] array = new int[x, y, z];
            Array3DFilling(array);
            PrintArray3D(array);
        }
    }
}