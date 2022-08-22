// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


using System;

namespace Homeworks
{
    class Program
    {

        static int[] ArrayFilling(int size)
        {
            int[] array = new int[size];
            Random randomArray = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomArray.Next(0, size);
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
        }
    }
}