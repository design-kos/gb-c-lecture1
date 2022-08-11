// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

static void Main(string[] args)
    {
        Console.WriteLine("Введи 2 числа и узнайте, какое из них больше, а какое меньше");
        int a, b;
        Console.WriteLine("Введи первое число - ");
        a = Convert.ToInt32(Console.Read());
        Console.WriteLine("Введи второе число - ");
        b = Convert.ToInt32(Console.Read());
 
        bool Compare0 = a > b;
        bool Compare1 = a == b;
        bool Compare2 = a < b;
 
        if (Chto0)
        {
            Console.WriteLine($"Число {a} больше чем {b}");
        }
        else if (Chto1)
        {
            Console.WriteLine($"Числа {a} и {b} равны");
        }
        else
        {
            Console.WriteLine($"Число {b} больше чем {a}");
        }