using System;
class Rectangle
{
    private double side1;
    private double side2;

    public Rectangle(double sideA, double sideB)
    {
        side1 = sideA;
        side2 = sideB;
    }

    private double CalculateArea()
    {
        return side1 * side2;
    }

    private double CalculatePerimeter()
    {
        return 2 * (side1 + side2);
    }

    public double Area
    {
        get { return CalculateArea(); }
    }

    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите длину первой стороны прямоугольника:");
        double sideA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите длину второй стороны прямоугольника:");
        double sideB = Convert.ToDouble(Console.ReadLine());

        Rectangle rectangle = new Rectangle(sideA, sideB);

        Console.WriteLine("Периметр прямоугольника: " + rectangle.Perimeter);
        Console.WriteLine("Площадь прямоугольника: " + rectangle.Area);
    }
}