using FigureOperations.Interfaces;

namespace FigureOperations.Models
{
    public class Circle : IFigure
    {
        public double R { get; private set; }

        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(R, 2);
            }
        }

        /// <exception cref="ArgumentException"></exception>
        public Circle(double r)
        {
            if (r <= 0)
                throw new ArgumentException("Круга с указанным радиусом не существует");

            R = r;
        }
    }
}
