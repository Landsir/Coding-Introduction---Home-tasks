// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int[] CreateArray(int[] array)
{
    Console.WriteLine("Input numbers of the array");
    for (int i=0; i < array.Length; i++)
    {
        
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void Demo(int[] array)
{
    Console.Write("[");
    for (int j=0; j<array.Length; j++)
    {
        Console.Write(array[j] + ", ");
    }
    Console.Write("]");
}
 
 Console.WriteLine("Input the size of the array");
 int size = Convert.ToInt32(Console.ReadLine());
 int[] myArray = new int [size];

 CreateArray(myArray);
 Demo(myArray);
