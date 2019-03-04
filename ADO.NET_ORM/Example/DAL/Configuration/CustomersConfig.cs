using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configuration
{
    class CustomersConfig : EntityTypeConfiguration<Customers>
    {
        public CustomersConfig()
        {
            this.ToTable("tbl_customers").HasKey(i => i.Id);
            this.Property(i => i.Id).HasColumnName("cln_customer_id");
            this.Property(i => i.Name).HasColumnName("cln_customer_name");
            this.Property(i => i.Address).HasColumnName("cln_customer_address");
            this.Property(i => i.City).HasColumnName("cln_customer_city");
            this.Property(i => i.State).HasColumnName("cln_customer_state");
            this.HasMany(i => i.Order).WithRequired().HasForeignKey(p => p.CustomerId);
        }
    }
}
