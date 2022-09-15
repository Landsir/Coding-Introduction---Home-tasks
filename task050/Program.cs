// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System;

void FillArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j=0; j < array.GetLength(1); j++)
        {
            array[i,j] = Convert.ToInt32(new Random().Next(1,100));
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

Console.WriteLine("Input rows' number");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input colomns' number");
int n = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [m,n];
FillArray(numbers);
PrintArray(numbers);
Console.WriteLine("Input a number");
int number = Convert.ToInt32(Console.ReadLine());
int a = 999;
     for (int i = 0; i < m; i++)
    {
        for (int j=0; j < n; j++)
        {
            if (numbers[i,j] == number)
            {
            a=numbers[i,j];
            break;
            }
        }
    }
    if (a!= 999)
    {
        Console.WriteLine("yes, there's such the number");
    } 
    else Console.WriteLine ("no, there's no such the number");
