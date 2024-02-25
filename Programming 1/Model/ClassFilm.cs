using System;

class Film
{
    private string Name;
    private int Time;
    private int YearOfIssue;
    private string Genre;
    private float Rating;
    public void SetNameTime(int Time)
    {
        if (Time < 0)
        {
            throw new ArgumentException("Время  не может быть отрицательным");
        }

        this.Time = Time;
    }

    public float GetNameTime()
    {
        return Time;
    }
    public void SetNameYearOfIssue (int Time)
    {
        if (YearOfIssue < 0)
        {
            throw new ArgumentException("Время  не может быть отрицательным");
        }

        this.Time = Time;
    }

    public float GetNameLengthYearOfIssue ()
    {
        return Time;
    }


}