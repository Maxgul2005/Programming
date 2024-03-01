using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_1.Model
{
    internal class Rectangle
    {
        private double Length;
        private double Width;
        private string Color { get; set; }
        public double length
        {
            get { return Length; }
            set
            {
                if (Length <= 0)
                {
                    throw new ArgumentException("Длина не может быть отрицательной");
                }
                Length = value;
            }

        }
        public double width 
        { get { return Width; }
            set 
            { 
                if (value <= 0) 
                {
                    throw new ArgumentException("Ширина должна быть положительным числом"); 
                }
                Width = value; 
            } 
        }

        public Rectangle()
        {
            Length = 15;
            Width = 30;
            Color = "Green";
        }


        public Rectangle(double length, double width, string color) 
        { Length = length; 
          Width = width; 
          Color = color; 
        }



    }
}
