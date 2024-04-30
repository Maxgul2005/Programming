using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;



class Contact
{
    private string _name;
    private string _surname;

    /// <summary>
    /// Имя контакта.
    /// </summary>
    public string Name
    {
        get { return _name; }
        set
        {
            AssertStringContainsOnlyLetters(value);
            _name = value;
        }
    }

    /// <summary>
    /// Фамилия контакта.
    /// </summary>
    public string Surname
    {
        get { return _surname; }
        set
        {
            AssertStringContainsOnlyLetters(value);
            _surname = value;
        }
    }

    /// <summary>
    /// Проверяет, содержит ли строка только буквы английского алфавита.
    /// </summary>
    /// <param name="value">Проверяемая строка.</param>
    private void AssertStringContainsOnlyLetters(string value)
    {
        if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
        {
            throw new ArgumentException("Строка должна содержать только символы английского алфавита.");
        }
    }
}

