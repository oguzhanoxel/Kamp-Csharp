using System;
using OOP.Abstract;
using OOP.Concreate;
using OOP.Entities;
using OOP.Adapters;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new PlayerManager(new EdevletServiceAdapter());
            OrderManager orderManager = new OrderManager();
            BaseDiscountManager winterDiscount = new WinterDiscountManager();
            BaseDiscountManager weekendDiscount = new WeekendDiscountManager();


            User user1 = new User();
            user1.Id = 0;
            user1.UserName = "blnm3";
            user1.FirstName = "oguzhan";
            user1.LastName = "oksel";
            user1.DateOfBirth = new DateTime(1996, 11, 13);

            Product product1 = new Product();
            product1.Title = "Darksouls";
            product1.Price = 150;

            Order order1 = new Order();
            order1.ProductFK = product1.Id;
            order1.Product = product1;
            order1.UserFK = user1.Id;
            order1.User = user1;

            userManager.Register(user1);
            userManager.Update(user1);
            orderManager.Create(order1);
            winterDiscount.discount(order1);
            orderManager.Create(order1);
            orderManager.Cancel(order1);
            userManager.Delete(user1);

            User user2 = new User();
            user2.Id = 0;
            user2.UserName = "TheDark";
            user2.FirstName = "birisi";
            user2.LastName = "biri";
            user2.DateOfBirth = new DateTime(1990, 10, 23);

            Product product2 = new Product();
            product2.Title = "Terraria";
            product2.Price = 20;

            Order order2 = new Order();
            order2.ProductFK = product2.Id;
            order2.Product = product2;
            order2.UserFK = user2.Id;
            order2.User = user2;

            userManager.Register(user2);
            orderManager.Create(order2);
            weekendDiscount.discount(order2);
            orderManager.Create(order2);
            orderManager.Cancel(order2);
        }
    }
}
