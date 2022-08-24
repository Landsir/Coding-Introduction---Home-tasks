Console.WriteLine("Введите число");
string number = Console.ReadLine();
int length = number.Length;

if (length>2)
    {
    char thirdChar = number[2];
    Console.WriteLine(thirdChar);
    }
else Console.WriteLine("Третьей цифры нет");
