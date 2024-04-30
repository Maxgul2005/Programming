using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    public string _fullName { get; set; }
    private readonly int _studentId;
    private string _numberGroup { get; set; }
    public int StudentId
    {
        get { return _studentId; }
    }

    public Student(string  fullName, int studentId, string numberGroup)
    {
        _fullName = fullName;
        _numberGroup = numberGroup;
        if (studentId < 100000 || studentId > 999999)
        {
            throw new ArgumentException("Неверный формат номера зачетки. Номер должен состоять из 6 цифр.");
        }
        _studentId = studentId;
    }
}

