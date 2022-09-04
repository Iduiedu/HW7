// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
using System;
class workhome
{
    public static void Main()
    {
        task50();
    }
    public static void task50()
    {
        Console.Write("Введите позицию элемента в массиве m = ");
        int m = Convert.ToInt16(Console.ReadLine());
        Console.Write("Введите позицию элемента в массиве n = ");
        int n = Convert.ToInt16(Console.ReadLine());
        double[,] mas = new double[4, 4];
        Random rnd = new Random();
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                mas[i, j] = rnd.Next(0, 10);
                Console.Write($"{mas[i, j]} \t");
            }
            Console.WriteLine();
        }
        if (m > 0 && m <= 4 && n > 0 && n <= 4)
        {
            Console.WriteLine("Значение элемента {0}", mas[m - 1, n - 1]);
        }
        else
        {
            Console.WriteLine("Такого элемента не существует");
        }
    }

}