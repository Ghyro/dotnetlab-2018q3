using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Order
    {
        public int Id { get; set; }

<<<<<<< HEAD
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        public Order()
        {
            this.OrderItems = new List<OrderItem>();
=======
        public virtual ICollection<Item> Items { get; set; }

        public Order()
        {
            this.Items = new List<Item>();
>>>>>>> 1c23a0cb8f3b54ae925267c6e31cf8f859cc0ca4
        }
    }
}
