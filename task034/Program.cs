﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray (int[] array1)
{
    int length = array1.Length;
    int index = 0;
    while (index < length)
    {
        array1[index] = new Random().Next(100, 1000);
        index++;
    }
//    for (int i=0; i < collection.Length; i++)
//    {
//     collection [i] = new Random().Next(100, 1000);
//    }
}
void Demo(int[] Demoarray)
{
    Console.Write("[");
    for (int j=0; j<Demoarray.Length; j++)
    {
        Console.Write(Demoarray[j] + ", ");
    }
    Console.Write("]");
}

int EvenNumber (int[] array1)
{
    int count = array1.Length;
    int i = 0;
    int evenNumber = 0;
    while (i < count)
    {
        if (array1[i]%2 == 0)
        evenNumber++;
        i++;
    }
    return(evenNumber);
}
Console.WriteLine("Input the size of your array");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];

FillArray(array);
Demo(array);
Console.WriteLine();
int pos = EvenNumber(array);
Console.WriteLine(pos);




