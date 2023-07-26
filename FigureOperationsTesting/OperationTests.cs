using FigureOperations.Interfaces;
using FigureOperations.Models;

namespace FigureOperationsTesting
{
    /// <summary>
    /// Тесты для проверки правильной работы операций над фигурами
    /// </summary>
    public class OperationTests
    {
        #region Треугольник
        /// <summary>
        /// Проверка на правильное получение площади треугольника
        /// </summary>
        [Fact]
        public void GetTriangleArea()
        {
            IFigure triangle = new Triangle(3, 4, 5);

            var area = triangle.Area;

            Assert.Equal(6, area);
        }

        /// <summary>
        /// Проверка на то, что треугольник прямоугольный
        /// </summary>
        [Fact]
        public void AssertTriangleIsRectangular()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            bool isRectanglular = triangle.IsRectangular;

            Assert.True(isRectanglular);
        }

        /// <summary>
        /// Проверка на то, что треугольник не прямоугольный
        /// </summary>
        [Fact]
        public void AssertTriangleIsNotRectangular()
        {
            Triangle triangle = new Triangle(2, 4, 5);

            bool isRectanglular = triangle.IsRectangular;

            Assert.False(isRectanglular);
        }
        #endregion

        #region Круг
        /// <summary>
        /// Проверка на правильное получение площади круга
        /// </summary>
        [Fact]
        public void GetCircleArea()
        {
            IFigure circle = new Circle(3);

            var areaRounded = Math.Round(circle.Area, 2);

            Assert.Equal(28.27, areaRounded);
        }
        #endregion

        #region Прямоугольник
        /// <summary>
        /// Проверка на правильное получение площади прямоугольника
        /// </summary>
        [Fact]
        public void GetRectangleArea()
        {
            IFigure rectangle = new Rectangle(3, 4);

            var area = rectangle.Area;

            Assert.Equal(12, area);
        } 
        #endregion
    }
}