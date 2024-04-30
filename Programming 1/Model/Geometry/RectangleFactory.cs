using System;

    public static class RectangleFactory
    {
        static readonly Random _random = new Random();

        /// <summary>
        /// Создает случайный прямоугольник.
        /// </summary>
        /// <returns>Случайный прямоугольник.</returns>
        public static Rectangle Randomize()
        {

            int x = _random.Next(10, 300);
            int y = _random.Next(10, 300);
            int width = _random.Next(10, 200);
            int length = _random.Next(30, 80);
            return new Rectangle(x, y, width, length);
        }
    }
