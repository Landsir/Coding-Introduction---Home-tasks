void palindrom()
        {
        Console.WriteLine("Введите пятизначное число");
        int number = Convert.ToInt32(Console.ReadLine());
        int num1 = number / 10000 % 10;
        int num2 = number / 1000 % 10;
        int rev1 = number / 10 % 10;
        int rev2 = number % 10;
        int nul = number / 10000;
        
            if (nul < 1 || nul > 9)
            {
            Console.WriteLine(number + " - " + "это не 5-значное число");
            }
            else if  (num1 == rev2 && num2 == rev1)
            {
            Console.WriteLine(number + " - да, это палиндром");
            }
            else{
            Console.WriteLine(number + " - нет, это не палиндром");
            }
        }
        for (int i = 0; i < 10; i++)
        { 
            palindrom();
    }