using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configuration
{
    public class ItemConfig : EntityTypeConfiguration<Item>
    {
        public ItemConfig()
        {
            this.ToTable("tbl_items").HasKey(i => i.Id);
            this.Property(i => i.Id).HasColumnName("cln_item_id");
            this.Property(i => i.Description).HasColumnName("cln_description");
            this.Property(i => i.Price).HasColumnName("cln_price");
        }
    }
}
