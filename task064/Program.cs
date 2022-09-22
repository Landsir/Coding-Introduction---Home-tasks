// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


Console.Write("Input number M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberN > numberM)
{for (int i =numberM; i <= numberN; i++)
    {
        Console.Write(i + " ");
    }
}
else
{
    for (int i = numberN; i <= numberM; i++)
    {
        Console.Write(i + " ");
    }
}