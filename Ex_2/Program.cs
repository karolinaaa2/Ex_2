using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть рік: ");
        int year = int.Parse(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        {
            Console.WriteLine("Рік є високосним.");
        }
        else
        {
            Console.WriteLine("Рік не є високосним.");
        }
    }
}
