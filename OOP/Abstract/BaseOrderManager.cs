using System;
using OOP.Entities;
using OOP.Abstract.Interface;

namespace OOP.Concreate
{
    public abstract class BaseOrderManager : IOrderService
    {
        public virtual void Cancel(Order order)
        {
            Console.WriteLine(order.Product.Title+ ":"+ order.Product.Price + " order canceled");
        }

        public virtual void Create(Order order)
        {
            Console.WriteLine(order.Product.Title + ":"+ order.Product.Price + " order created");
        }
    }
}