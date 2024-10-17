using System;
using System.Runtime.Remoting.Messaging;


public class Item
{
    // Поля класса
    private readonly int _id; //целочисленное readonly-поле, хранящее уникальный номер товара.
    private string _name; //строковое поле с названием товара, до 200 символов.
    private string _info; //строковое поле с описанием товара, до 1 000 символов.
    private double _cost; //вещественное поле со стоимостью товара, от 0 до 100 000

    /// <summary>
    /// Категория товара.
    /// </summary>
    public Category Category { get; set; }

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
            ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
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
            ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
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
            if (value < 0 || value > 100000)
            {
                throw new ArgumentException("Стоимость товара должна быть в диапазоне от 0 до 100 000.");
            }
            _cost = value;
        }
    }

    /// <summary>
    /// Конструктор класса Item.
    /// </summary>
    /// <param name="name">Наименование товара.</param>
    /// <param name="info">Подробная информация о товаре.</param>
    /// <param name="cost">Стоимость товара.</param>
    /// <param name="category">Категория товара.</param>
    public Item(string name, string info, double cost, Category category)
    {
        _id = IdGenerator.GetNextId();
        Name = name;
        Info = info;
        Cost = cost;
        Category = category;
    }

  
    /// <summary>
    /// Создает пустой/начальный экземпляр класса.Всем полям присваивается значение по умолчанию.
    /// </summary>
    public Item()
    {
        _id = IdGenerator.GetNextId();
        Name = "None";
        Info = "None";
        Cost = 0;
    }

    
}