using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Сколько чисел будем сортировать?");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите числа для сортировки");
        int[] mas=new int[N];
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i]= Convert.ToInt32(Console.ReadLine());
        }
        BubbleSort(mas);
        Console.WriteLine("После сортировки");
        for (int i = 0; i < mas.Length; i++)
        {
            Console.WriteLine(mas[i]);
        }
        Console.ReadLine();
            
    }

    private static void BubbleSort(int[] mas)
    {
        throw new NotImplementedException();
    }
}
