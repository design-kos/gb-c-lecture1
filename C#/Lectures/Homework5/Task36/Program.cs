// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях(по индексу считаем).


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
                array[i] = new Random().Next(1, 100);
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

            int sumEven = 0;
            int sumOdd = 0;
            for (int z = 0; z < array.Length; z++)
            {
                if (z % 2 == 0)
                {
                    sumEven  = sumEven  + array[z];
                }
                else
                {
                    sumOdd  = sumOdd  + array[z];
                }
            }
            Console.WriteLine($"Сумма чисел с четным индексом в полученном массиве - {sumEven}");
            Console.WriteLine($"Сумма чисел с нечетным индексом в полученном массиве - {sumOdd}");
        }
    }
}