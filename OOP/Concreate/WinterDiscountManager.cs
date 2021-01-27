using System;
using OOP.Entities;
using OOP.Abstract;

namespace OOP.Concreate
{
    public class WinterDiscountManager:BaseDiscountManager
    {
        public override void discount(Order order)
        {   
            order.Product.Price = order.Product.Price * 0.70;
            Console.WriteLine("Kış indirimi uygulandı yeni fiyat :" + order.Product.Price);
            base.discount(order);
        }
    }
}