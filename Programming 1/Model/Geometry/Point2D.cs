public class Point2D
{
	private double _x;
	private double _y;

	/// <summary>
	/// ��������� � ������ ���������� X. � ��������� �� ������������� ��������.
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
    /// ��������� � ������ ���������� X. � ��������� �� ������������� ��������.
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
    /// ������� ��������� ������ Point2D. � ����������� X � Y
    /// </summary>
    /// <param name="x">��������� � ������ ���������� X</param>
    /// <param name="y">��������� � ������ ���������� Y</param>
    public Point2D(double x, double y)
	{
		X = x ;
		Y = y;
	}
}