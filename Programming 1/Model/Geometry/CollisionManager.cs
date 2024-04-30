using System;

static class CollisionManager
{
    /// <summary>
    /// Проверяет наличие пересечения между двумя прямоугольниками.
    /// </summary>
    /// <param name="rectangle1">Первый прямоугольник.</param>
    /// <param name="rectangle2">Второй прямоугольник.</param>
    /// <returns>True, если прямоугольники пересекаются, в противном случае - False.</returns>
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

    /// <summary>
    /// Проверяет наличие коллизии между двумя кольцами.
    /// </summary>
    /// <param name="ring1">Первый кольцо.</param>
    /// <param name="ring2">Второй кольцо.</param>
    /// <returns>True, если кольца пересекаются, в противном случае - False.</returns>
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




