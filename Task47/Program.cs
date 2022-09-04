// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
using System;
class workhome
{
    public static void Main()
    {
        task47();
    }

    public static void task47()
    {
        Console.Write("Введите размер массива m = ");
        int m = Convert.ToInt16(Console.ReadLine());
        Console.Write("Введите размер массива n = ");
        int n = Convert.ToInt16(Console.ReadLine());
        double[,] mas = new double[m, n];
        Random rnd = new Random();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                mas[i, j] = Math.Round(rnd.Next(-10, 10) + rnd.NextDouble(), 2);
                Console.Write($"{mas[i, j]} \t");
            }
            Console.WriteLine();
        }

    }
}
