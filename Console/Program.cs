using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int num = int.Parse(Console.ReadLine());

        if (num > 1)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(num + " не является простым числом");
                    break;
                }
                else if (i == num - 1)
                {
                    Console.WriteLine(num + " является простым числом");
                }
            }
        }
        else
        {
            Console.WriteLine(num + " не является простым числом");
        }
    }
}