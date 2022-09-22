// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

 Console.Write("Input number M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int j =0;
int sum = 0;
int M = numberM;
for ( int i = numberM; i <= numberN; i++)
{
    sum = sum + (M +j) ;
    j++;
}
Console.WriteLine($"Sum of natural elements of the interval is {sum} ");




