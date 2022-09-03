Console.WriteLine("Input number");
string number = Console.ReadLine();
int result = 0;

for (int i = 0; i < number.Length; i++)
{
    result += number[i] - '0';
}
Console.WriteLine(result);
