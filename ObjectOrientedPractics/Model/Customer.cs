using System;
using System.Net;

public class Customer
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

    //Конструктор
    /// <summary>
    /// Создает пустой/начальный экземпляр класса.Всем полям присваивается значение по умолчанию.
    /// </summary>
    public Customer()
    {
        Fullname = "None";
        Address = new Address();
        _id = IdGenerator.GetNextId();

    }
    /// <summary>
    /// Конструктор Customer
    /// </summary>
    /// <param name="fullname"> Полное имя</param>
    /// <param name="address">Адресс покупателя</param>
    public Customer(string  fullname)
    {
        _id = IdGenerator.GetNextId();
        Fullname = fullname; 
        Address = new Address();
    }



}
