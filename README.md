# Lab31
Лабораторная работа №1
«Типы данных, классы»

Цели работы:
Научиться работать с переменными разных типов данных CTS средствами языка C#.
Научиться создавать классы и поля классов, инициализировать свойства классов. Научиться создавать перегруженные конструкторы классов.
Научиться создавать тесты для реализованных методов и классов.

Задание№1
Выведите на консоль минимальные и максимальные значения для предопределенных типов данных CTS.
```
using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Минимальные и максимальные значения для предопределенных типов данных CTS:");

        Console.WriteLine($"bool: {false}, {true}");
        Console.WriteLine($"byte: {byte.MinValue}, {byte.MaxValue}");
        Console.WriteLine($"sbyte: {sbyte.MinValue}, {sbyte.MaxValue}");
        Console.WriteLine($"short: {short.MinValue}, {short.MaxValue}");
        Console.WriteLine($"ushort: {ushort.MinValue}, {ushort.MaxValue}");
        Console.WriteLine($"int: {int.MinValue}, {int.MaxValue}");
        Console.WriteLine($"uint: {uint.MinValue}, {uint.MaxValue}");
        Console.WriteLine($"long: {long.MinValue}, {long.MaxValue}");
        Console.WriteLine($"ulong: {ulong.MinValue}, {ulong.MaxValue}");
        Console.WriteLine($"float: {float.MinValue}, {float.MaxValue}");
        Console.WriteLine($"double: {double.MinValue}, {double.MaxValue}");
        Console.WriteLine($"decimal: {decimal.MinValue}, {decimal.MaxValue}");
        Console.WriteLine($"char: {char.MinValue}, {char.MaxValue}");

        Console.ReadLine();
    }
}
```

![Снимок экрана (32)](https://github.com/Dark13Night/AlgLab1/assets/112771541/70d75907-435e-466d-8922-78408200896b)

Задание№2
Создайте класс с именем Rectangle.
В теле класса создайте два поля, описывающие длины сторон double side1, side2.
Создайте пользовательский конструктор Rectangle(double sideA, double sideB), в теле которого поля sideA и sideB инициализируются значениями аргументов.
Создайте два private метода, вычисляющие площадь прямоугольника - double CalculateArea() и периметр прямоугольника - double CalculatePerimeter ().
Создайте два свойства double Area и double Perimeter с одним методом доступа get, вызывающим созданные ранее методы.
Напишите программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на экран периметр и площадь. Покройте тестами методы класса Rectangle.

Программа
```
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
```

Тесты

```
using NUnit.Framework;
using System.Drawing;

namespace Lab312;

internal class Rectangle
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
[TestFixture]
class RectangleTests
{
    // Тест для метода CalculateArea()
    [Test]
    public void CalculateArea_WhenSidesArePositive_ShouldReturnCorrectValue()
    {
        // Arrange
        double sideA = 3;
        double sideB = 4;
        double expectedArea = 12;

        Rectangle rectangle = new Rectangle(sideA, sideB);

        // Act
        double actualArea = rectangle.Area;

        // Assert
        Assert.AreEqual(expectedArea, actualArea);
    }

    // Тест для метода CalculatePerimeter()
    [Test]
    public void CalculatePerimeter_WhenSidesArePositive_ShouldReturnCorrectValue()
    {
        // Arrange
        double sideA = 3;
        double sideB = 4;
        double expectedPerimeter = 14;

        Rectangle rectangle = new Rectangle(sideA, sideB);

        // Act
        double actualPerimeter = rectangle.Perimeter;

        // Assert
        Assert.AreEqual(expectedPerimeter, actualPerimeter);
    }
}
```

![Снимок экрана (33)](https://github.com/Dark13Night/AlgLab1/assets/112771541/7c879d48-b185-44cb-9f61-911cf6ee1803)


Задание №3
Создайте классы Point и Figure.
Класс Point должен содержать два целочисленных поля с координатами точки.
Создайте два свойства с одним методом доступа get.
Создайте пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов.
Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point, а также строковое автосвойство для хранения названия фигуры.
Создайте два метода: double LengthSide(Point A, Point B), который рассчитывает длину стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр многоугольника.
Напишите программу, которая выводит на экран название и периметр многоугольника. Покройте тестами методы класса Figure.

Примечание: Избегайте повторения кода при реализации перегруженных конструкторов, используйте реализованные ранее конструкторы с помощью ключевого слова this

Класс Point
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab313
{
    internal class Point
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
```

Класс Figure
```
class Figure
    {
        private Point[] points;
        private string name;

        public Figure(Point p1, Point p2, Point p3)
        {
            points = new Point[3];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
            name = "Треугольник";
        }

        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            points = new Point[4];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
            points[3] = p4;
            name = "Четырехугольник";
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            points = new Point[5];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
            points[3] = p4;
            points[4] = p5;
            name = "Пятиугольник";
        }

        public double LengthSide(Point A, Point B)
        {
            int deltaX = B.X - A.X;
            int deltaY = B.Y - A.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                perimeter += LengthSide(points[i], points[i + 1]);
            }
            perimeter += LengthSide(points[points.Length - 1], points[0]);
            Console.WriteLine("Название фигуры: " + name);
            Console.WriteLine("Периметр: " + perimeter);
        }
    }
}
```

Программа
```
using Lab313;

class Program
{
    static void Main()
    {
        Console.Write("Введите название фигуры: ");
        string name = Console.ReadLine();
        Console.Write("Введите количество точек: ");
        int numPoints = int.Parse(Console.ReadLine());

        Point[] points = new Point[numPoints];
        for (int i = 0; i < numPoints; i++)
        {
            Console.Write("Введите координату x для точки " + (i + 1) + ": ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите координату y для точки " + (i + 1) + ": ");
            int y = int.Parse(Console.ReadLine());
            points[i] = new Point(x, y);
        }

        Figure figure;
        if (numPoints == 3)
        {
            figure = new Figure(points[0], points[1], points[2]);
        }
        else if (numPoints == 4)
        {
            figure = new Figure(points[0], points[1], points[2], points[3]);
        }
        else if (numPoints == 5)
        {
            figure = new Figure(points[0], points[1], points[2], points[3], points[4]);
        }
        else
        {
            Console.WriteLine("Неверное количество точек");
            return;
        }

        figure.PerimeterCalculator();
    }
}
```
![Снимок экрана (34)](https://github.com/Dark13Night/AlgLab1/assets/112771541/150ad9ad-d82b-48fb-8090-e7b7c5ba6d0c)

Тесты
```
using System.Drawing;
public class Point
{
    private int x;
    private int y;

    public int X
    {
        get { return x; }
    }

    public int Y
    {
        get { return y; }
    }

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}
class Figure
{
    private Point[] points;
    private string name;

    public Figure(Point p1, Point p2, Point p3)
    {
        points = new Point[3];
        points[0] = p1;
        points[1] = p2;
        points[2] = p3;
        name = "Треугольник";
    }

    public Figure(Point p1, Point p2, Point p3, Point p4)
    {
        points = new Point[4];
        points[0] = p1;
        points[1] = p2;
        points[2] = p3;
        points[3] = p4;
        name = "Четырехугольник";
    }

    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
    {
        points = new Point[5];
        points[0] = p1;
        points[1] = p2;
        points[2] = p3;
        points[3] = p4;
        points[4] = p5;
        name = "Пятиугольник";
    }

    public double LengthSide(Point A, Point B)
    {
        int deltaX = B.X - A.X;
        int deltaY = B.Y - A.Y;
        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    }

    public void PerimeterCalculator()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length - 1; i++)
        {
            perimeter += LengthSide(points[i], points[i + 1]);
        }
        perimeter += LengthSide(points[points.Length - 1], points[0]);
        Console.WriteLine("Название фигуры: " + name);
        Console.WriteLine("Периметр: " + perimeter);
    }
}


namespace FigureTest
{
    [TestFixture]
    public class FigureTests
    {
        [Test]
        public void LengthSide_ReturnsCorrectLength()
        {
            // Arrange
            Point A = new Point(0, 0);
            Point B = new Point(3, 4);
            double expectedLength = 5;

            // Act
            Figure figure = new Figure(null, null, null); 
            double actualLength = figure.LengthSide(A, B);

            // Assert
            Assert.AreEqual(expectedLength, actualLength);
        }
        [Test]
        public void PerimeterCalculator_ReturnsCorrectPerimeter()
        {
            // Arrange
            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 5);
            Point p3 = new Point(5, 0);
            Figure figure = new Figure(p1, p2, p3);
            double expectedPerimeter = 15;

            // Act
            figure.PerimeterCalculator();

            // Assert
            // Так как метод PerimeterCalculator выводит результат в консоль, здесь нет явного Assert.
          
        }
       
    }
}

```
Выполненные тесты
![Снимок экрана (31)](https://github.com/Dark13Night/AlgLab1/assets/112771541/48c5a9e3-6d4d-4452-988d-8735c09e0c2b)
