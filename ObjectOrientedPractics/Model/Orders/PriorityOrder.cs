using System;
using System.Collections.Generic;

public class PriorityOrder: Order
{
    // Дополнительное поле для хранения времени доставки
    public DateTime DeliveryTime { get; set; }
    public DeliveryTimeRange DeliveryTimeRange { get; set; } 
    public PriorityOrder(OrderStatus status, string dateOfCreation, List<Item> items, Address address, DateTime deliveryTime, double discountAmount, DeliveryTimeRange deliveryTimeRange)
       : base(status, dateOfCreation, items, address, discountAmount)
    {
        DeliveryTime = deliveryTime;
        DeliveryTimeRange = DeliveryTimeRange;
    }
}

