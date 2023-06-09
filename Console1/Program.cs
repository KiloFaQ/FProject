﻿// подключаем пространство имен
using System;

// создаем класс программы
class Program
{
    // создаем метод Main
    static void Main(string[] args)
    {
        // выводим сообщение пользователю и запрашиваем ввод числа
        Console.Write("Введите число: ");
        int num = int.Parse(Console.ReadLine());

        // проверяем, что число больше 1
        if (num > 1)
        {
            // запускаем цикл от 2 до num
            for (int i = 2; i < num; i++)
            {
                // если число делится на i без остатка, то выводим сообщение и выходим из цикла
                if (num % i == 0)
                {
                    Console.WriteLine(num + " не является простым числом");
                    break;
                }
                // если дошли до конца цикла и не нашли делителей, то число простое
                else if (i == num - 1)
                {
                    Console.WriteLine(num + " является простым числом");
                }
            }
        }
        // если число меньше или равно 1, то оно не является простым
        else
        {
            Console.WriteLine(num + " не является простым числом");
        }
    }
}
