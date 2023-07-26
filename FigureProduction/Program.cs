using FigureOperations.Interfaces;
using FigureOperations.Models;

try
{
	Triangle triangle = new Triangle(3, 4, 5);
	Console.WriteLine(triangle.Area);
    Console.WriteLine(triangle.IsRectangular);
}
catch (Exception ex)
{
    Console.WriteLine($"Произошла ошибка при попытке создать треугольник: {ex.Message}");
}

IFigure circle = new Circle(3);


Console.WriteLine(Math.Round(circle.Area, 2));
