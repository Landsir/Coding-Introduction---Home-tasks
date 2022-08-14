Console.WriteLine("Введите два числа, чтобы узнать, какое большее.");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1>number2)
    Console.WriteLine("Большее число: " + number1);
else
    Console.WriteLine("Большее число: " + number2);
