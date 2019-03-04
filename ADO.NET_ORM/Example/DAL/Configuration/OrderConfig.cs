﻿using DAL.Entities;
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
            this.Property(i => i.CustomerId).HasColumnName("cln_customer_id");
            this.HasMany(i => i.OrderItems).WithRequired().HasForeignKey(p => p.OrderId);
        }
    }
}
