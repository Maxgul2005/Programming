using System;

class Flight
{
    private string DeparturePoint { get; set; }
    private string Destination { get; set; }
    private int FlightTime;
    public void SetNameFlightTime(int FlightTime)
    {
        if (FlightTime < 0)
        {
            throw new ArgumentException("����� ������ �� ����� ���� �������������");
        }

        this.FlightTime = FlightTime;
    }

    public float GetNameFlightTime()
    {
        return FlightTime;
    }


}