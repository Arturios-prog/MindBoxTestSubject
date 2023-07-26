using FigureOperations.Interfaces;

namespace FigureOperations.Models
{
    public class Triangle : IFigure
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        /// <summary>
        /// Площадь по формуле Гирона
        /// </summary>
        public double Area
        {
            get
            {
                var p = (A + B + C) / 2;
                var area = Math.Sqrt(Math.Abs(p * (p - A) * (p - B) * (p - C)));

                return area;
            }
        }

        public bool IsRectangular
        {
            get
            {
                var max = Math.Max(A, Math.Max(B, C));

                if (A == max)
                    return isRectangular(A, B, C);
                if (B == max)
                    return isRectangular(B, C, A);

                return isRectangular(C, A, B);
            }
        }

        private bool isRectangular(double hypo, double a, double b)
        {
            return Math.Pow(hypo, 2) == Math.Pow(a, 2) + Math.Pow(b, 2);
        }

        /// <exception cref="ArgumentException">Проверка на существование треугольника с указанными сторонами</exception>
        public Triangle(double a, double b, double c)
        {
            if (a >= b + c || b >= c + a || c >= a + b)
                throw new ArgumentException("Треугольник с обозначенными сторонами не существует");

            A = a; B = b; C = c;
        }
    }
}
