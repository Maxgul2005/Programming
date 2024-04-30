public class Point2D
{
	private double _x;
	private double _y;

	/// <summary>
	/// Возращает и задает координату X. С проверкой на положительное значение.
	/// </summary>
	public double X
	{
		get { return _x; }
		private set
		{
			Validator.AssertOnPositiveValue(value,"X");
			_x = value;
		}
	}

    /// <summary>
    /// Возращает и задает координату X. С проверкой на положительное значение.
    /// </summary>
    public double Y
	{
		get { return _y; }
		private set
		{
			Validator.AssertOnPositiveValue(value,"Y");
			_y = value;
		}
	}

    /// <summary>
    /// Создает экземпляр класса Point2D. С параметрами X и Y
    /// </summary>
    /// <param name="x">Возращает и задает координату X</param>
    /// <param name="y">Возращает и задает координату Y</param>
    public Point2D(double x, double y)
	{
		X = x ;
		Y = y;
	}
}