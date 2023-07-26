using FigureOperations.Interfaces;
using FigureOperations.Models;

namespace FigureOperationsTesting
{
    /// <summary>
    /// ����� ��� �������� ���������� ������ �������� ��� ��������
    /// </summary>
    public class OperationTests
    {
        #region �����������
        /// <summary>
        /// �������� �� ���������� ��������� ������� ������������
        /// </summary>
        [Fact]
        public void GetTriangleArea()
        {
            IFigure triangle = new Triangle(3, 4, 5);

            var area = triangle.Area;

            Assert.Equal(6, area);
        }

        /// <summary>
        /// �������� �� ��, ��� ����������� �������������
        /// </summary>
        [Fact]
        public void AssertTriangleIsRectangular()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            bool isRectanglular = triangle.IsRectangular;

            Assert.True(isRectanglular);
        }

        /// <summary>
        /// �������� �� ��, ��� ����������� �� �������������
        /// </summary>
        [Fact]
        public void AssertTriangleIsNotRectangular()
        {
            Triangle triangle = new Triangle(2, 4, 5);

            bool isRectanglular = triangle.IsRectangular;

            Assert.False(isRectanglular);
        }
        #endregion

        #region ����
        /// <summary>
        /// �������� �� ���������� ��������� ������� �����
        /// </summary>
        [Fact]
        public void GetCircleArea()
        {
            IFigure circle = new Circle(3);

            var areaRounded = Math.Round(circle.Area, 2);

            Assert.Equal(28.27, areaRounded);
        }
        #endregion

        #region �������������
        /// <summary>
        /// �������� �� ���������� ��������� ������� ��������������
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