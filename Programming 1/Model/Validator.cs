using System;
static class Validator
{
    public static void AssertOnPositiveValue(double value, string propertyName)
    {
        if (value < 0.0)
        {
            throw new ArgumentException($"Значение должно быть положительным. Свойство: {propertyName}");
        }
    }

    public static void AssertOnPositiveValue(int value, string propertyName)
    {
        if (value < 0)
        {
            throw new ArgumentException($"Значение должно быть положительным. Свойство: {propertyName}");
        }
    }

    public static void AssertValueInRange(int value, int min, int max, string propertyName)
    {
        if (value < min || value > max)
        {
            throw new ArgumentOutOfRangeException(propertyName, value, $"Значение должно быть {propertyName} от {min} до {max}.");
        }
    }


}