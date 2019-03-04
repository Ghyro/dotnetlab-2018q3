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

        public virtual ICollection<Item> Items { get; set; }

        public Order()
        {
            this.Items = new List<Item>();
        }
    }
}
