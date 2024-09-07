using System;
using System.Net;

class Customer
{
    // Поле-счетчик для генерации уникальных ID
    private static int _idCounter = 0;

    // Поля класса
    private readonly int _id; //целочисленное readonly-поле, хранящее уникальный номер товара.
    private string _fullname; //строковое поле с полным именем покупателя 
    private string _address; //строковое поле с адресом доставки для покупателя

    /// <summary>
    /// Свойство на чтение для Id
    /// </summary>
    public int Id
    {
        get { return _id; }
    }

    /// <summary>
    /// Свойство для работы с полем _fullname с валидацией
    /// </summary>
    public string Fullname
    {
        get { return _fullname; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length > 200)
            {
                throw new ArgumentException("Полное имя должно быть не пустым и содержать менее 200 символов.");
            }
            _fullname = value;
        }
    }

    /// <summary>
    /// Свойство для работы с полем _address с валидацией
    /// </summary>
    public string Address
    {
        get { return _address; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length > 500)
            {
                throw new ArgumentException("Адрес должен быть не пустым и содержать менее 500 символов.");
            }
            _address = value;
        }
    }

    /// <summary>
    /// Конструктор Customer
    /// </summary>
    /// <param name="fullname">Полное имя</param>
    /// <param name="address">Адресс покупателя</param>
    public Customer(string  fullname, string address)
    {
        _id = GetNextId();
        Fullname = fullname; 
        Address = address;
    }

    /// <summary>
    /// Метод для генерации уникальных Id
    /// </summary>
    /// <returns></returns>
    private static int GetNextId()
    {
        return ++_idCounter;
    }

}
