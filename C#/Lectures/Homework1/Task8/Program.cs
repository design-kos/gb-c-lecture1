﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

using System;
 
namespace Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int N = Convert.ToInt32(Console.ReadLine());   
 
                for (int i = 2; i <= N; i += 2) Console.WriteLine(i);

        }
    }
}