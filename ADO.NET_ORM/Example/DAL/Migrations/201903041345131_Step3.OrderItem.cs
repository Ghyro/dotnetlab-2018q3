namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Step3OrderItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_order_items", "cln_quantity", c => c.Int(nullable: false));

            Sql(@"update tbl_order_items
                set cln_quantity=23
                where cln_order_id=111 and cln_item_id=1");

            Sql(@"update tbl_order_items
                set cln_quantity=42
                where cln_order_id=111 and cln_item_id=2");

            Sql(@"update tbl_order_items
                set cln_quantity=2
                where cln_order_id=222 and cln_item_id=1");

            Sql(@"update tbl_order_items
                set cln_quantity=77
                where cln_order_id=222 and cln_item_id=2");
        }
        
        public override void Down()
        {
            DropColumn("dbo.tbl_order_items", "cln_quantity");
        }
    }
}
