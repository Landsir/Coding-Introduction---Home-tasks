// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;

void FillArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j=0; j < array.GetLength(1); j++)
        {
            array[i,j] = Convert.ToInt32(new Random().Next(1,20));
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void PrintArray (int[,] array)
{
    for (int i =0; i < array.GetLength(0); i++)
    {
        for(int j =0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + "\t");
    }
        Console.WriteLine();
    }
}

double Average(int[,] array, int column)
{
    double average = 0;
    double x =0;
    for (int i =0; i< array.GetLength(0); i++)
    {
        average += array[i, column];
    }
    x = average/array.GetLength(0);
    return x;
}
Console.WriteLine("Input rows' number");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input colomns' number");
int n = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [m,n];

FillArray(numbers);
PrintArray(numbers);

double result = 0;

for (int j = 0; j < n; j++)
{
    result = Average(numbers, j);
    Console.WriteLine("Arithmetical mean is " + result);
}