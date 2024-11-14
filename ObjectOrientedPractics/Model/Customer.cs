using System;
using ObjectOrientedPractics.Model;
using System.Collections.Generic;
using System.Net;
using ObjectOrientedPractics.Model.Discounts;

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
    /// корзина покупателя.
    /// </summary>
    Cart _cart;
    /// <summary>
    /// Список заказов пользователя
    /// </summary>
    private List<Order> _orders;

    private List<IDiscount> _discounts;
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
    /// Получает или задает корзину товаров.
    /// </summary>
    public Cart Cart { get; set; }
    /// <summary>
    /// Получает или задает заказ.
    /// </summary>
    public List<Order> Orders { get; set; }

    /// <summary>
    /// Возвращает или меняет приоритет клиента.
    /// </summary>
    public bool IsPriority { get; set; }

    public List<IDiscount> Discounts { get; set; }

    //Конструктор
    /// <summary>
    /// Создает пустой/начальный экземпляр класса.Всем полям присваивается значение по умолчанию.
    /// </summary>
    public Customer()
    {
        Fullname = "None";
        Address = new Address();
        Cart = new Cart();
        Orders = new List<Order>();
        Discounts = new List<IDiscount>();
        Discounts.Add(new PointsDiscount());
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
        Cart = new Cart();
        Address = new Address();
        Orders = new List<Order>();
    }

    public override string ToString()
    {
        return Fullname;
    }


}
