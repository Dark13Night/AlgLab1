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