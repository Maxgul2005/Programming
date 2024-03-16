using Programming_1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rectangle
{
    private double _length;

    private double _widtht;

   

    public double Length
    {
        get
        {
            return _length;
        }
        set
        {
            Validator.AssertOnPositiveValue(value, "Длина");
            _length = value;
        }
    }

    public double Widtht
    {
        get
        {
            return _widtht;
        }
        set
        {
            Validator.AssertOnPositiveValue(value, "Ширина");
            _widtht = value;
        }
    }
   

    public string Color { get; set; }
    public Point2D Center { get; set; }
   
    public Rectangle()
    {
        Length = 0.0;
        Widtht = 0.0;
        Color = "None";
        Center = new Point2D(0, 0);
    }
    public Rectangle(double length, double widtht, string color, Point2D center)
    {
        Length = length;
        Widtht = widtht;
        Color = color;
        Center = center;
    }

    
    
}
