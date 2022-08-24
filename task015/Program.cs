internal class Program
{
    private static void Main(string[] args)
    {
Console.WriteLine("Введите день недели числом");
int day = Convert.ToInt32(Console.ReadLine());

if (day>0 && day < 7)
    {
        if(day==7 || day==6)
        {
            Console.WriteLine(day + "-ой день недели - выходной день.");
        }
        else Console.Write(day + " - это рабочий день.");
    } 
else Console.WriteLine(" Это число не обозначает день недели.");
}
}