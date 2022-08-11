// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

using System;
 
namespace Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());   
 
            Console.WriteLine(num1 % 2 == 0 ? "Четное" : "Нечетное");

        }
    }
}