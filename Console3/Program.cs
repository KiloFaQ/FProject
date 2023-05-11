using System;

class Circle
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double Area()
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public double Circumference()
    {
        return 2 * Math.PI * radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5);

        Console.WriteLine("Площадь круга: " + circle.Area());
        Console.WriteLine("Длина окружности: " + circle.Circumference());
    }
}
