namespace FigureOperations.Interfaces
{
    // Плюс интерфейса - мы обязываем переопределить получение площади, т.к. для каждый фигуры оно разное
    public interface IFigure
    {
        double Area { get; }
    }
}
