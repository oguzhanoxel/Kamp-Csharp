using System;

namespace OOP.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public int UserFK { get; set; } // Foreign key
        public User User { get; set; }

        public int ProductFK { get; set; } // Foreign key
        public Product Product { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}