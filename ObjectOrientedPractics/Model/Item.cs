using System;
using System.Runtime.Remoting.Messaging;

class Item
{
    // Поле-счетчик для генерации уникальных ID
    private static int _idCounter = 0;

    // Поля класса
    private readonly int _id; //целочисленное readonly-поле, хранящее уникальный номер товара.
    private string _name; //строковое поле с названием товара, до 200 символов.
    private string _info; //строковое поле с описанием товара, до 1 000 символов.
    private double _cost; //вещественное поле со стоимостью товара, от 0 до 100 000

    /// <summary>
    /// Свойство для Id
    /// </summary>
    public int Id
    {
        get { return _id; }
    }

    /// <summary>
    /// Свойства для поля _name
    /// </summary>
    public string Name
    {
        get { return _name; }
        set
        {
            if (value.Length >= 200)
            {
                throw new ArgumentException("Поле с названием товара должно быть менее, чем 200 символов");
            }
            _name = value;
        }
    }

    /// <summary>
    /// Свойство для поля _info
    /// </summary>
    public string Info
    {
        get { return _info; }
        set
        {
            if (value.Length >= 1000)
            {
                throw new ArgumentException("Поле с описанием товара должно бьть менее, чем 200 символов");
            }
            _info = value;
        }
    }

    /// <summary>
    /// Свойство для поля _cost
    /// </summary>
    public double Cost
    {
        get { return _cost; }
        set
        {
            if (value > 100000)
            {
                throw new ArgumentException("Поле товара должно быть меньше, чем 100К");
            }
            _cost = value;
        }
    }

    /// <summary>
    /// Конструктор с параметрами Item
    /// </summary>
    /// <param name="name">name</param>
    /// <param name="info">info</param>
    /// <param name="cost">cost</param>
    public Item(string name, string info, double cost)
    {
        _id = GetNextId();
        Name = name;
        Info = info;
        Cost = cost;
    }

    /// <summary>
    /// Метод для генерации уникального ID
    /// </summary>
    /// <returns>Уникальный идентификатор товара</returns>
    private static int GetNextId()
    {
        return ++_idCounter;
    }

}