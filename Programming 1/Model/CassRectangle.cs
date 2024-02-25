using System;

class Rectangle
{
    private float Length;
    private float Width;
    private string Color { get; set; }

    public void SetNameLength(float Length)
    {
        if (Length < 0)
        {
            throw new ArgumentException("ƒлина не может быть отрицательной");
        }

        this.Length = Length;
    }

    public float GetNameLength()
    {
        return Length;
    }

    public void GetNameWidth(float Length)
    {
        if (Width < 0)
        {
            throw new ArgumentException("Ўирина не может быть отрицательной");
        }

        this.Width = Width;
    }

    public float GetNameWidth()
    {
        return Width;
    }




}