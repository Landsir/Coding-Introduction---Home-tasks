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
        Console.Write(Demoarray[j] + "  ");
    }
    Console.Write("]" );
}

void MultiPulti (int [] array2, int [] array3)
{
int i = 0;
int j = array2.Length-1;

while (i < array2.Length/2)
{
    int multi = array2[i] * array2[j];
    array3[i] = multi;
    i++;
    j--;

}
if (array2.Length % 2 !=0)
{
    array3[array2.Length/2] = array2[array2.Length/2];
}
}

int [] array = new int [4];
int [] multiarray = new int [array.Length/2];
int [] multiarrayNotEven = new int [array.Length/2 + 1];
FillArray(array);
Demo(array);
Console.WriteLine();

if (array.Length % 2 == 0)
{
MultiPulti(array, multiarray);
Demo (multiarray);
}
else
{
MultiPulti (array, multiarrayNotEven);
Demo (multiarrayNotEven);
}
