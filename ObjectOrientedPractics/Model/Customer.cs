using System;
using System.Net;

class Customer
{
    

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
            ValueValidator.AssertStringOnLength(value,200,nameof(Fullname));
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
            ValueValidator.AssertStringOnLength(value, 500, nameof(Address));
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
        _id = IdGenerator.GetNextId();
        Fullname = fullname; 
        Address = address;
    }

  

}
