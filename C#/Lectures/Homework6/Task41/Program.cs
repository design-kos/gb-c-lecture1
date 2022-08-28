// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


using System;

namespace Homeworks
{
    class Program
    {
        // static int[] InputNumbers(int m)
        // {
        //     int[] userArray = new int[m];

        //     for (int i = 0; i < m; i++)
        //     {
        //         Console.Write($"Введите число №{i + 1}: ");
        //         userArray[i] = Convert.ToInt32(Console.ReadLine());
        //     }
        //     return userArray;
        // }

        static int[] InputNumbers(int[] userArray, int m, int index = 0)
        {
            {
                if (index < m)
                {
                    Console.Write($"Введите число № {index + 1}: ");
                    userArray[index] = Convert.ToInt32(Console.ReadLine());
                    InputNumbers(userArray, m, index + 1);
                }
            }
            return userArray;
        }

        static void PrintArray(int[] userArray)
        {
            int count = userArray.Length;
            int index = 0;

            Console.Write("[");
            while (index < count)
            {
                Console.Write(userArray[index]);
                index++;
                if (index < count)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("]");
        }

        static int FindNumbersGreaterThanZero(int[] userArray)
        {
            int count = 0;
            for (int i = 0; i < userArray.Length; i++)
            {
                if (userArray[i] > 0) count += 1;
            }
            return count;
        }

        static void Main(string[] args)
        {

            Console.Write("Укажите количество чисел: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[] userArray = new int[m];
            
            int[] filledArray = InputNumbers(userArray, m);
            PrintArray(filledArray);
            Console.WriteLine();
            int count = FindNumbersGreaterThanZero(filledArray);

            Console.WriteLine($"Количество чисел больше 0: {count}");
        }
    }
}