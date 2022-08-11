// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

using System;
 
namespace Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
 
            if(num1 > num2)
            {
                Console.WriteLine($"Число {num1} больше чем {num2}");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"Число {num2} больше чем {num1}");
            }
            else
            {
                Console.WriteLine($"Числа {num1} и {num2} равны");
            }
        }
    }
}