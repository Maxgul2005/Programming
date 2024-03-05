using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_1.Model
{
    internal class Rectangle
    {
        private double _length;

        private double _widtht;

        private string _color;

        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException("Длина положительна!");
                }
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
                if (value < 0.0)
                {
                    throw new ArgumentException("Длина положительна!");
                }
                _widtht = value;
            }
        }

        public string Color { get; set; }

        public Rectangle()
        {
            Length = 0.0;
            Widtht = 0.0;
            Color = "None";
        }
        public Rectangle(double length, double widtht, string color)
        {
            Length = length;
            Widtht = widtht;
            Color = color;
        }



    }
}
