using Programming_1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rectangle
{
    private int _length;

    private int _widtht;

    private static int _allRectanglesCount;

    private int _id;

    public int Id
    {
        get { return _id; }
    }

    public static int AllRectanglesCount
    {
        get { return _allRectanglesCount; }
    }

    public int Length
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

    public int Widtht
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
        Length = 0;
        Widtht = 0;
        Color = "None";
        Center = new Point2D(0, 0);
        _id = ++_allRectanglesCount;
    }
    public Rectangle(int length, int widtht, string color, Point2D center)
    {
        Length = length;
        Widtht = widtht;
        Color = color;
        Center = center;
        _id = ++_allRectanglesCount;
    }

   
    private int _x;
    public int X
    {
        get { return _x; }
        set 
        {
            Validator.AssertOnPositiveValue(value, "_X");
            _x = value;
        }
    }
    private int _y;
    public int Y
    {
        get { return _y; }
        set
        {
            Validator.AssertOnPositiveValue(value, "_y");
            _y = value;
        }
    }

    public Rectangle(int x, int y, int width, int length)
    {
        X = x;
        Y = y;
        Widtht = width;
        Length = length;
        _id = ++_allRectanglesCount;

    }


}
