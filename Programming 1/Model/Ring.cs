using System;

class Ring
{
    private Point2D _center;
    private double _innerRadius;
    private double _outerRadius;
    public Point2D Center
    {
        get { return _center; }
        set 
        {
          _center = value; 
        }
    }

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
    public double Area
    {
        get
        {
            return Math.PI * (Math.Pow(_outerRadius, 2) - Math.Pow(_innerRadius, 2));
        }
    }
    public Ring(Point2D center, double innerRadius, double outerRadius)
    {
        Center = center;
        InnerRadius = innerRadius;
        OuterRadius = outerRadius;
    }
}