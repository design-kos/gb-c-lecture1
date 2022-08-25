// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


using System;

namespace Homeworks
{
    class Program
    {

        static int[] ArrayFilling(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(100, 1000);
            }
            return array;
        }

        static void PrintArray(int[] array)
        {
            int count = array.Length;
            int index = 0;

            Console.Write("[");
            while (index < count)
            {
                Console.Write(array[index]);
                index++;
                if (index < count)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("]");
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Укажите длину массива: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array = ArrayFilling(size);
            PrintArray(array);
            Console.WriteLine();

            int count = 0;
            for (int z = 0; z < array.Length; z++)
            {
                if (array[z] % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"В полученном массиве {count} четных чисел");
        }
    }
}