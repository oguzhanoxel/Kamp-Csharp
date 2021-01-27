using System;
using OOP.Entities;
using OOP.Abstract;

namespace OOP.Concreate
{
    public class WeekendDiscountManager:BaseDiscountManager
    {
        public override void discount(Order order)
        {   
            order.Product.Price = order.Product.Price * 0.90;
            Console.WriteLine("Haftasonu indirimi uygulandı yeni fiyat :" + order.Product.Price);
            base.discount(order);
        }
    }
}