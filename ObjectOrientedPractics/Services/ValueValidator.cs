using System;

class ValueValidator
{
    /// <summary>
    /// Метод проверяет длину строки и выбрасывает исключение, если она превышает maxLength.
    /// </summary>
    public static void AssertStringOnLength(string value, int maxLength, string propertyName)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length > maxLength)
        {
            throw new ArgumentException("Название товара должно быть не пустым и содержать не более 200 символов.");
        }
    }
}

