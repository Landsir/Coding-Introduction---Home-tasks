// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void FillArray (int[] array1)
{
    int length = array1.Length;
    int index = 0;
    while (index < length)
    {
        array1[index] = new Random().Next(1,200);
        index++;
    }
}
   
int [] array = new int [123];
FillArray(array);

int count = 0;
    for (int index = 0; index < array.Length; index++)
    {
       if (array[index] > 9 && array[index] < 100)
       {
        count++;
        Console.Write(array[index] + ", ");
       }
     
    }  
Console.WriteLine();
Console.WriteLine("Количество элементов: " + count);
