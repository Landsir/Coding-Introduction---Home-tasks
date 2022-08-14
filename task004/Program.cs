Console.WriteLine("Введите число, больше 1");
int number1 = Convert.ToInt32(Console.ReadLine());
int count = 2;

    while (number1 >= count)
    {
        Console.WriteLine(count);
        count = count + 2;
    }


