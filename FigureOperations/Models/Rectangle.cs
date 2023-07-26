using FigureOperations.Interfaces;

namespace FigureOperations.Models
{

    //Добавление новой фигуры - определение базовых свойств и имплементация вычисления площади
    public class Rectangle : IFigure
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double Area
        {
            get
            {
                return A * B;
            }
        }

        /// <exception cref="ArgumentException"></exception>
        public Rectangle(double a, double b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new ArgumentException("Прямоугольника с указаными сторонами не существует");
            }

            A = a; B = b;
        }
    }
}
