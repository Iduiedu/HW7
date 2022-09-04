// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
class workhome
{
    public static void Main()
    {
        task52();
    }

    public static void task52()
    {
        Console.Write("Введите размер массива m = ");
        int m = Convert.ToInt16(Console.ReadLine());
        Console.Write("Введите размер массива n = ");
        int n = Convert.ToInt16(Console.ReadLine());
        double[,] mas = new double[m, n];
        Random rnd = new Random();
        Console.WriteLine("Исходный массив:");
        double srd=0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                mas[i,j]=rnd.Next(0,10);
                Console.Write($"{mas[i, j]} \t");
            }
            Console.WriteLine();
        }
        for (int j= 0; j < n; j++)
        {
            for (int i = 0; i < m; i++)
            {
                srd+=mas[i,j];
            }
            Console.Write("{0};",Math.Round(srd/m,2));
            srd=0;
        }
    }
}

