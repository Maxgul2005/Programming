using System;
public static class Validator
{
    /// <summary>
    /// ���������, ��� �������� �������� ������������� ������.
    /// </summary>
    /// <param name="value">����������� ��������.</param>
    /// <param name="propertyName">��� ��������, � ������� ������������� ��������.</param>
    /// <exception cref="ArgumentException">�������������, ���� �������� �������������.</exception>
    public static void AssertOnPositiveValue(double value, string propertyName)
    {
        if (value < 0.0)
        {
            throw new ArgumentException($"�������� ������ ���� �������������. ��������: {propertyName}");
        }
    }

    /// <summary>
    /// ���������, ��� �������� �������� ������������� ������.
    /// </summary>
    /// <param name="value">����������� ��������.</param>
    /// <param name="propertyName">��� ��������, � ������� ������������� ��������.</param>
    /// <exception cref="ArgumentException">�������������, ���� �������� �������������.</exception>
    public static void AssertOnPositiveValue(int value, string propertyName)
    {
        if (value < 0)
        {
            throw new ArgumentException($"�������� ������ ���� �������������. ��������: {propertyName}");
        }
    }

    /// <summary>
    /// ���������, ��� �������� ��������� � �������� ���������.
    /// </summary>
    /// <param name="value">����������� ��������.</param>
    /// <param name="min">����������� �������� ���������.</param>
    /// <param name="max">������������ �������� ���������.</param>
    /// <param name="propertyName">��� ��������, � ������� ������������� ��������.</param>
    /// <exception cref="ArgumentOutOfRangeException">�������������, ���� �������� �� ��������� � ���������.</exception>
    public static void AssertValueInRange(int value, int min, int max, string propertyName)
    {
        if (value < min || value > max)
        {
            throw new ArgumentOutOfRangeException(propertyName, value, $"�������� ������ ���� {propertyName} �� {min} �� {max}.");
        }
    }
}