using System;

static class CollisionManager
{
    public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
    {
        double halfWidth1 = rectangle1.Widtht / 2;
        double halfHeight1 = rectangle1.Length / 2;
        double halfWidth2 = rectangle2.Widtht / 2;
        double halfHeight2 = rectangle2.Length / 2;

        double deltaX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
        double deltaY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);


        if (deltaX < halfWidth1 + halfWidth2 && deltaY < halfHeight1 + halfHeight2)
        {
            return true; // Rectangles are colliding
        }

        return false; // Rectangles are not colliding
    }

    public static bool IsCollision(Ring ring1, Ring ring2)
    {
        double distance = (double)Math.Sqrt(Math.Pow(ring2.Center.X - ring1.Center.X, 2) + Math.Pow(ring2.Center.Y - ring1.Center.Y, 2));
        double sumRadii = ring1.OuterRadius + ring2.OuterRadius;

        if (distance < sumRadii)
        {
            return true; // Rings are colliding
        }

        return false; // Rings are not colliding
    }
}




