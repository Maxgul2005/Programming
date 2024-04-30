using System;

class Ring
{
    private Point2D _center;
    private double _innerRadius;
    private double _outerRadius;

    /// <summary>
    /// Возращает и задает центр кольца.
    /// </summary>
    public Point2D Center
    {
        get { return _center; }
        set 
        {
          _center = value; 
        }
    }

    /// <summary>
    /// Внутренний радиус кольца.
    /// </summary>
    public double InnerRadius
    {
        get { return _innerRadius; }
        set
        {
            if (value <= 0 || value >= _outerRadius)
                throw new ArgumentException("Inner radius should be a positive number less than the outer radius");
            _innerRadius = value;
        }
    }

    /// <summary>
    /// Внешний радиус кольца.
    /// </summary>
    public double OuterRadius
    {
        get { return _outerRadius; }
        set
        {
            if (value <= 0 || value <= _innerRadius)
                throw new ArgumentException("Outer radius should be a positive number greater than the inner radius");
            _outerRadius = value;
        }
    }

    /// <summary>
    /// Возращает Площадь кольца.
    /// </summary>
    public double Area
    {
        get
        {
            return Math.PI * (Math.Pow(_outerRadius, 2) - Math.Pow(_innerRadius, 2));
        }
    }

    /// <summary>
    /// Создает экземпляр кольца.
    /// </summary>
    /// <param name="center">Центр кольца.</param>
    /// <param name="innerRadius">Внутренний радиус кольца.</param>
    /// <param name="outerRadius">Внешний радиус кольца.</param>
    public Ring(Point2D center, double innerRadius, double outerRadius)
    {
        Center = center;
        InnerRadius = innerRadius;
        OuterRadius = outerRadius;
    }
}