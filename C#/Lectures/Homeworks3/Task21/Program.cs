// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


using System;

namespace Homeworks
{
    class Program
    {
        static double distanceСalculation(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double d = Math.Pow((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) * 1.0), 0.5);
            return d;
        }

        static void Main(string[] args)
        {

            Console.Write("Введите координаты первой точки - x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты первой точки - y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());   

            Console.Write("Введите координаты первой точки - z1: ");
            double z1 = Convert.ToDouble(Console.ReadLine());                     

            Console.Write("Введите координаты второй точки - x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты второй точки - y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты второй точки - z2: ");
            double z2 = Convert.ToDouble(Console.ReadLine());

            double distance = distanceСalculation(x1, y1, z1, x2, y2, z2);
            Console.WriteLine("Расстояние между точками равно " + distance);
        }
    }
}