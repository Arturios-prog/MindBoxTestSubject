using FigureOperations.Models;

namespace FigureOperationsTesting
{
    /// <summary>
    /// Тесты для проверки правильной работы валидации фигур
    /// </summary>
    public class ValidationTests
    {
        /// <summary>
        /// Треугольник задан правильно
        /// </summary>
        [Fact]
        public void InvalidTriangleThrowsArgumentException() 
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var triangle = new Triangle(3, 4, 7);
            });
        }

        /// <summary>
        /// Круг задан правильно
        /// </summary>
        [Fact]
        public void InvalidCircleThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var circle = new Circle(-3);
            });
        }

        /// <summary>
        /// Прямоугольник задан правильно
        /// </summary>
        [Fact]
        public void InvalidRectangleThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var rectangle = new Rectangle(-1, 1);
            });
        }
    }
}
