using System.Collections.Generic;
/// <summary>
/// Хранит данные о корзине покупок:Список товаров,Суммарная стоимость всех товаров.
/// </summary>
public class Cart
{
    /// <summary>
    /// Список товаров.
    /// </summary>
    private List<Item> _items;
    /// <summary>
    /// Суммарная стоимость всех товаров.
    /// </summary>
    private double _amount;
    /// <summary>
    /// Задает и возращает список товаров
    /// </summary>
    public List<Item> Items
    {
        get { return _items; }
        set { _items = value; }
    }
    /// <summary>
    /// Возвращает суммарную стоимость всех товаров.
    /// </summary>
    public double Amount
    {
        get 
        {
            double summ = 0;
            foreach (Item cost in Items)
            {
                summ += cost.Cost;
            }
            if (summ > 0)
            {
                return _amount = summ;
            }
            else
            {
                return _amount = 0;
            }
        }
    }

    /// <summary>
    /// Конструктор CArt без прааметров
    /// </summary>
    public Cart()
    {
        Items = new List<Item>();
    }

}

