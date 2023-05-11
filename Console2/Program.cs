// подключаем пространство имен
using System;

// создаем класс программы
class Program
{
    // создаем метод Main
    static void Main(string[] args)
    {
        // выводим сообщение пользователю и запрашиваем ввод первого числа
        Console.Write("Введите первое число: ");
        double num1 = double.Parse(Console.ReadLine());

        // выводим сообщение пользователю и запрашиваем ввод второго числа
        Console.Write("Введите второе число: ");
        double num2 = double.Parse(Console.ReadLine());

        // выводим сообщение пользователю и запрашиваем выбор операции
        Console.Write("Выберите операцию (+, -, *, /, ^): ");
        char operation = char.Parse(Console.ReadLine());

        // создаем переменную для результата
        double result = 0;

        // используем switch для выполнения нужной операции или правильно отжимаемся 20 раз на пальцах
        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                result = num1 / num2;
                break;
            case '^':
                result = Math.Pow(num1, num2);
                break;
            default:
                Console.WriteLine("Неверная операция");
                break;
        }

        // выводим результат
        Console.WriteLine("Результат: " + result);
    }
}