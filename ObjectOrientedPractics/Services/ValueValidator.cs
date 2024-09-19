﻿using System;

class ValueValidator
{
    /// <summary>
    /// Метод проверяет длину строки и выбрасывает исключение, если она превышает maxLength.
    /// </summary>
    public static void AssertStringOnLength(string value, int maxLength, string propertyName)
    {
        if ( value.Length > maxLength)
        {
            throw new ArgumentException($"{propertyName} должен быть меньше {maxLength} символов.");
        }
    }
}

