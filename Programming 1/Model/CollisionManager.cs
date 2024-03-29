using System;

static class CollisionManager
{
    public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
    {
        // Рассчитываем половинные размеры прямоугольников
        double halfWidth1 = rectangle1.Widtht / 2;
        double halfHeight1 = rectangle1.Length / 2;
        double halfWidth2 = rectangle2.Widtht / 2;
        double halfHeight2 = rectangle2.Length / 2;

        // Рассчитываем расстояние между центрами прямоугольников
        double deltaX = Math.Abs(rectangle1.X + halfWidth1 - rectangle2.X - halfWidth2);
        double deltaY = Math.Abs(rectangle1.Y + halfHeight1 - rectangle2.Y - halfHeight2);

        // Проверяем условие пересечения
        if (deltaX < halfWidth1 + halfWidth2 && deltaY < halfHeight1 + halfHeight2)
        {
            return true; // Прямоугольники пересекаются
        }

        return false; // Прямоугольники не пересекаются
    }

    public static bool IsCollision(Ring ring1, Ring ring2)
    {
        double distance = (double)Math.Sqrt(Math.Pow(ring2.Center.X - ring1.Center.X, 2) + Math.Pow(ring2.Center.Y - ring1.Center.Y, 2));
        double sumRadii = ring1.OuterRadius + ring2.OuterRadius;

        if (distance < sumRadii)
        {
            return true; 
        }

        return false; 
    }
}




