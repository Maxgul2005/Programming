using System.Collections.Generic;
using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
/// <summary>
/// Класс который хранит в себе заказ покупателя.
/// </summary>
public class Order
{

    private int _id;
    private static int _allOrdersCount;
    private OrderStatus _status;
    private string _dateOfCreation;
    private Address _deliveryAddress;
    private List<Item> _items;
    private double _totalCost;



    public int Id { get; }
    public OrderStatus Status { get; set; }
    public string DateOfCreation { get; }
    public Address DeliveryAddress { get; set; }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public List<Item> Items { get; set; }
    public double TotalCost
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
                return _totalCost = summ;
            }
            else
            {
                return _totalCost = 0;
            }
        }
    }

    public Order()
    {
        Status = OrderStatus.New;
        DateOfCreation = "01.01.2000";
        DeliveryAddress = new Address();
        
        _allOrdersCount += 1;
        _id = _allOrdersCount;
    }
    public Order(OrderStatus status, string dateOfCreation, List<Item> items)
    {
        Status = status;
        DateOfCreation = dateOfCreation;
        Items = new List<Item>(items); ;
    }
}
