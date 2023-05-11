using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.Write("Выберите операцию (+, -, *, /, ^): ");
        char operation = char.Parse(Console.ReadLine());

        double result = 0;

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

        Console.WriteLine("Результат: " + result);
    }
}
