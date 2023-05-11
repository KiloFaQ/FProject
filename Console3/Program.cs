// создаем класс Circle
class Circle
{
    // переменная радиус
    double radius;

    // конструктор класса
    public Circle(double r)
    {
        radius = r;
    }

    // метод нахождения площади круга
    public double GetArea()
    {
        return Math.PI * radius * radius;
    }

    // метод нахождения длины окружности
    public double GetCircumference()
    {
        return 2 * Math.PI * radius;
    }
}

// создаем класс программы
class Program
{
    // создаем метод Main
    static void Main(string[] args)
    {
        // создаем объект класса Circle и передаем ему значение радиуса
        Circle circle = new Circle(5);

        // выводим результаты методов в консоль
        Console.WriteLine("Площадь круга: " + circle.GetArea());
        Console.WriteLine("Длина окружности: " + circle.GetCircumference());
    }
}
