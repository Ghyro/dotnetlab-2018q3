using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configuration
{
    public class OrderConfig : EntityTypeConfiguration<Order>
    {
        public OrderConfig()
        {
            this.ToTable("tbl_orders").HasKey(i => i.Id);
            this.Property(i => i.Id).HasColumnName("cln_order_id");
            this.HasMany(i => i.Items).WithMany(p => p.Orders).Map(m =>
            {
                m.MapLeftKey("cln_order_id");
                m.MapRightKey("cln_item_id");
                m.ToTable("tbl_order_items");
            });
        }
    }
}
