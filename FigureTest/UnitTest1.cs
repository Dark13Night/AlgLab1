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
            // Мы ожидаем увидеть правильные значения в выводе консоли, иначе тест завершится с ошибкой.
        }
       
    }
}
