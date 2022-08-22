// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


using System;

namespace Homeworks
{
    class Program
    {
        static int Exponentiation(int A, int B)
        {
            int result = 1;
            for (int i = 1; i <= B; i++)
            {
                result = result * A;
            }
            return result;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Введите число: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень, в которую нужно возвести число: ");
            int B = Convert.ToInt32(Console.ReadLine());

            int exponentiation = Exponentiation(A, B);
            Console.WriteLine($"{A}^{B} = " + exponentiation);
        }
    }
}