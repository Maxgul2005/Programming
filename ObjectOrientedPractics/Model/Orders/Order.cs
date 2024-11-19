﻿using System.Collections.Generic;
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
    private double _amount;
    private double _discountAmount;


    public int Id { get; }
    public OrderStatus Status { get; set; }
    public string DateOfCreation { get; }
    public Address DeliveryAddress { get; set; }
    /// <summary>
    /// Размер примененной скидки
    /// </summary>
    public double DiscountAmount
    {
        get
        {
            return _discountAmount;
        }
        set
        {
          
            _discountAmount = value;
        }
    }
    public double Total
    {
        get
        {
            return Amount - DiscountAmount;
        }
    }
    public List<Item> Items { get; set; }
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

    public Order()
    {
        Status = OrderStatus.New;
        DateOfCreation = "01.01.2000";
        DeliveryAddress = new Address();
        Items = new List<Item>();

        _allOrdersCount += 1;
        Id = _allOrdersCount;
    }
    public Order(OrderStatus status, string dateOfCreation, List<Item> items, Address address, double discountAmount)
    {
        Status = status;
        DateOfCreation = dateOfCreation;
        Items = new List<Item>(items);
        DeliveryAddress = address;
        DiscountAmount = discountAmount;

        _allOrdersCount += 1;
        Id = _allOrdersCount;
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
        if (!(other is  Order))
            return false;
        if (object.ReferenceEquals(this, other))
            return true;
        Order order = (Order)other;
        return (this.Status == order.Status && this.DateOfCreation == order.DateOfCreation && this.Items == order.Items && this.DeliveryAddress == order.DeliveryAddress && this.DiscountAmount == order.DiscountAmount);
    }

}
