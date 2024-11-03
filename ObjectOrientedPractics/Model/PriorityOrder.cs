using System;
using System.Collections.Generic;

public class PriorityOrder: Order
{
    // Дополнительное поле для хранения времени доставки
    public DateTime DeliveryTime { get; set; }
    public DeliveryTimeRange DeliveryTimeRange { get; set; } 
    public PriorityOrder(OrderStatus status, string dateOfCreation, List<Item> items, DateTime deliveryTime, DeliveryTimeRange deliveryTimeRange)
       : base(status, dateOfCreation, items)
    {
        DeliveryTime = deliveryTime;
        DeliveryTimeRange = DeliveryTimeRange;
    }
}

