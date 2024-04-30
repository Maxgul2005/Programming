using System;
public static class Validator
{
    /// <summary>
    /// Проверяет, что значение является положительным числом.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <param name="propertyName">Имя свойства, с которым ассоциируется значение.</param>
    /// <exception cref="ArgumentException">Выбрасывается, если значение отрицательное.</exception>
    public static void AssertOnPositiveValue(double value, string propertyName)
    {
        if (value < 0.0)
        {
            throw new ArgumentException($"Значение должно быть положительным. Свойство: {propertyName}");
        }
    }

    /// <summary>
    /// Проверяет, что значение является положительным числом.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <param name="propertyName">Имя свойства, с которым ассоциируется значение.</param>
    /// <exception cref="ArgumentException">Выбрасывается, если значение отрицательное.</exception>
    public static void AssertOnPositiveValue(int value, string propertyName)
    {
        if (value < 0)
        {
            throw new ArgumentException($"Значение должно быть положительным. Свойство: {propertyName}");
        }
    }

    /// <summary>
    /// Проверяет, что значение находится в заданном диапазоне.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <param name="min">Минимальное значение диапазона.</param>
    /// <param name="max">Максимальное значение диапазона.</param>
    /// <param name="propertyName">Имя свойства, с которым ассоциируется значение.</param>
    /// <exception cref="ArgumentOutOfRangeException">Выбрасывается, если значение не находится в диапазоне.</exception>
    public static void AssertValueInRange(int value, int min, int max, string propertyName)
    {
        if (value < min || value > max)
        {
            throw new ArgumentOutOfRangeException(propertyName, value, $"Значение должно быть {propertyName} от {min} до {max}.");
        }
    }
}