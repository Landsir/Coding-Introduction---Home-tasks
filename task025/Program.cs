Console.WriteLine("Input number A ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number B");
int numberB = Convert.ToInt32(Console.ReadLine());
int count = 0;
int result = numberA;

while (count < numberB-1)
{
result = (result * numberA);
count++;
}
Console.WriteLine(result);

