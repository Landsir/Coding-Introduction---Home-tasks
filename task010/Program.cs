internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите трехзначное число");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 999)
        {
            if (number > 99)
            {
                number = number % 100;
                number = number / 10;

                Console.WriteLine(number);

            }
            else Console.WriteLine("Вы ввели неверное число");   
        }

        else Console.WriteLine("Вы ввели неверное число");
    }
}