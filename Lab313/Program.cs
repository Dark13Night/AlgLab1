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