using System;
using System.Runtime.Remoting.Messaging;


public class Item: ICloneable, IComparable<Item>
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

    public override string ToString()
    {
        return Name;
    }

    /// <summary>
    /// Делает копию объекта по всем полям, кроме Id.
    /// </summary>
    /// <returns></returns>
    public object Clone()
    {
        return new Item(this.Name, this.Info, this.Cost, this.Category);
    }
    /// <summary>
    /// Объекты равны тогда, когда у них равны все поля кроме ID.
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public override bool Equals(object other)
    {
        if (other == null)
            return false;
        if (!(other is Item))
            return false;
        if (object.ReferenceEquals(this, other))   // Если оба объекта ссылаются на одну и ту же область памяти, то они равны
            return true;
        Item item = (Item)other;
        return (this.Name == item.Name && this.Info == item.Info && this.Cost == item.Cost && this.Category == item.Category);
    }
    /// <inheritdoc/>
    public int CompareTo(Item item2)
    {
        if (item2 == null)
            throw new ArgumentNullException(nameof(item2));

        // Проверка на идентичность ссылок
        if (ReferenceEquals(this, item2))
            return 0;

        // Сравнение стоимости
        if (Cost > item2.Cost)
        {
            return 1;
        }
        if (Cost < item2.Cost)
        {
            return -1;
        }
        return 0; // Если стоимость равна
    }

}