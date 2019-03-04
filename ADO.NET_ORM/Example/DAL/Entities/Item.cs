using System.Collections.Generic;

namespace DAL.Entities
{
    public class Item
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

<<<<<<< HEAD
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        public Item()
        {
            this.OrderItems = new List<OrderItem>();
=======
        public virtual ICollection<Order> Orders { get; set; }

        public Item()
        {
            this.Orders = new List<Order>();
>>>>>>> 1c23a0cb8f3b54ae925267c6e31cf8f859cc0ca4
        }
    }
}
