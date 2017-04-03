namespace WebApiServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustomerStatus", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "CustomerStatus");
        }
    }
}
