using Programming_1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Rectangle

    {
        private int _length;
        private int _widtht;
        private static int _allRectanglesCount;
        private int _id;

        /// <summary>
        /// Возращает уникальный идентификатор прямоугольника.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Возращает общее количество прямоугольников.
        /// </summary>
        public static int AllRectanglesCount
        {
            get { return _allRectanglesCount; }
        }

        /// <summary>
        /// Возращает и задает длину прямоугльника, с проверкой на положительное значение.
        /// </summary>
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

        /// <summary>
        /// Возращает и задает ширину прямоугльника, с проверкой на положительное значение.
        /// </summary>
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

        /// <summary>
        /// Возращает и задает цвет прямоугольника.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Возращает и задает центр прямоугльника.
        /// </summary>
        public Point2D Center { get; set; }

        public Rectangle()
        {
            Length = 0;
            Widtht = 0;
            Color = "None";
            Center = new Point2D(0, 0);
            _id = ++_allRectanglesCount;
        }

        /// <summary>
        /// Создает экземпляр класса 
        /// </summary>
        /// <param name="length">Длина прямоугольника. Должна быть положительным значением.</param>
        /// <param name="widtht">Ширина прямоугольника. Должна быть положительным значением.</param>
        /// <param name="color">Цвет прямоугольника.</param>
        /// <param name="center">Центр прямоугольника.</param>
        public Rectangle(int length, int widtht, string color, Point2D center)
            {
                Length = length;
                Widtht = widtht;
                Color = color;
                Center = center;
                _id = ++_allRectanglesCount;
            }


        private int _x;

        /// <summary>
        /// Возращает и задает X, с проверкой на положительное значение.
        /// </summary>
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

        /// <summary>
        /// Возращает и задает Y, с проверкой на положительное значение.
        /// </summary>
        public int Y
        {
            get { return _y; }
            set
            {
                Validator.AssertOnPositiveValue(value, "_y");
                _y = value;
            }
        }
        /// <summary>
        /// Создает экземпляр класса прямоугольника с заданными координатами, шириной и длиной.
        /// </summary>
        /// <param name="x">Координата X.</param>
        /// <param name="y">Координата Y.</param>
        /// <param name="width">Ширина прямоугольника.</param>
        /// <param name="length">Длина прямоугольника.</param>
        public Rectangle(int x, int y, int width, int length)
        {
            X = x;
            Y = y;
            Widtht = width;
            Length = length;
            _id = ++_allRectanglesCount;

        }


    }
