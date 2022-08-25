// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


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

        static void FindMaxAndMinIndexes(int[] array, out int min, out int max, out int minIndex, out int maxIndex)
        {
            min = array[0];
            max = array[0];
            minIndex = 0;
            maxIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }
                else if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Укажите длину массива: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array = ArrayFilling(size);
            PrintArray(array);
            Console.WriteLine();

            int minN, maxN, minNIndex, maxNIndex;
            FindMaxAndMinIndexes(array, out minN, out maxN, out minNIndex, out maxNIndex);
            Console.WriteLine($"Минимальное число массива - {minN}, его индекс - {minNIndex}");
            Console.WriteLine($"Максимальное число массива - {maxN}, его индекс - {maxNIndex}");

            int sumMinToMax = 0;
            if (minNIndex < maxNIndex)
            {
                for (int z = minNIndex + 1; z < maxNIndex; z++)
                {
                    sumMinToMax = sumMinToMax + array[z];
                }
                Console.WriteLine($"Сумма чисел, находящихся между минимальным и максимальным индексами - {sumMinToMax}");
            }
            else if (maxNIndex < minNIndex)
            {
                for (int z = maxNIndex + 1; z < minNIndex; z++)
                {
                    sumMinToMax = sumMinToMax + array[z];
                }
                Console.WriteLine($"Сумма чисел, находящихся между минимальным и максимальным индексами - {sumMinToMax}");
            }
            else 
            {
                Console.WriteLine($"Максимальное и минимальное число имеют один индекс");
            }

        }
    }
}