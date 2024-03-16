using System;
static class Validator
{
    public static void AssertOnPositiveValue(double value, string propertyName)
    {
        if (value < 0.0)
        {
            throw new ArgumentException($"�������� ������ ���� �������������. ��������: {propertyName}");
        }
    }
}