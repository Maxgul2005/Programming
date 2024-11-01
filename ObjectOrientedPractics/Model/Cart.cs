using System.Collections.Generic;
using System.ComponentModel;
/// <summary>
/// Хранит данные о корзине покупок:Список товаров,Суммарная стоимость всех товаров. Корзина агрегирует список товаров
/// </summary>
public class Cart
{
    /// <summary>
    /// Список товаров.Корзина агрегирует список товаров
    /// </summary>
    private List<Item> _items;
    /// <summary>
    /// Суммарная стоимость всех товаров.
    /// </summary>
    private double _amount;
    /// <summary>
    /// Задает и возращает список товаров
    /// </summary>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
            return _amount = summ;
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

