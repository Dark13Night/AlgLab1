using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab313
{
    internal class Figure
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