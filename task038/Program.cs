// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным
//  и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray (int[] array1)
{
    int length = array1.Length;
    int index = 0;
    while (index < length)
    {
        array1[index] = new Random().Next(1, 100);
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
    Console.Write("]");
}

int MaxNumber (int[] array1)
{
    int count = array1.Length;
    int i = 0;
    int max = array1[0];
    while (i < count)
    {
        if (max < array1[i])
        {
            max = array1[i];
        }
        i++;
    }
    return(max);
}
  
int MinNumber (int[] array1)
{
    int count1 = array1.Length;
    int indexMin = 0;
    int min = array1[0];
    
    while (indexMin < count1)
    {
        if (min > array1[indexMin])
        {min = array1[indexMin];
        }
        indexMin++;
    }
    return(min);
}  

Console.WriteLine("Input the size of your array");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];

FillArray(array);
Demo(array);
int dif = MaxNumber(array) - MinNumber(array);

Console.WriteLine();
Console.WriteLine(MaxNumber(array));
Console.WriteLine(MinNumber(array));
Console.WriteLine(dif);



