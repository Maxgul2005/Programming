using System;
using System.Net;

class Customer
{
    /// <summary>
    /// Идентификатор клиента.
    /// </summary>
    readonly int _id;

    /// <summary>
    /// Полное имя клиента.
    /// </summary>
    /// 
    string _fullname;

    /// <summary>
    /// Адрес клиента.
    /// </summary>
    Address _address;

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
    public Address Address
    {
        get { return _address; }
        set
        {
            _address = value;
        }
    }


    /// <summary>
    /// Конструктор Customer
    /// </summary>
    /// <param name="fullname"> Полное имя</param>
    /// <param name="address">Адресс покупателя</param>
    public Customer(string  fullname, Address address)
    {
        _id = IdGenerator.GetNextId();
        Fullname = fullname; 
        Address = address;
    }

    public override string ToString()
    {
        return $"Id: {_id}, Fullname - {_fullname}, Address - {_address} ";
    }

}
