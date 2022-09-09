// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//  Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
void FillArray (int[] array1)
{
    int length = array1.Length;
    int index = 0;
    while (index < length)
    {
        array1[index] = new Random().Next(1, 10);
        index++;
    }
}
void Demo(int[] Demoarray)
{
    Console.Write("[");
    for (int j=0; j<Demoarray.Length; j++)
    {
        Console.Write(Demoarray[j] + ", ");
    }
    Console.Write("] => ");
}

int [] array = new int [5];
FillArray(array);
Demo(array);
Console.WriteLine();

int length = (array.Length)/2;
int count = 0;
int i = 0;
int j = array.Length-1;
while (count < length)
{
    int multi = array[i] * array[j];
    i++;
    j--;
    count++;
    Console.Write(" " + multi);
}
if (array.Length %2 != 0)
{
    Console.Write(" " + array[length]);
}

        
        


