namespace WebApiServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullableUpdateAndDelete : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Updated", c => c.DateTime());
            AlterColumn("dbo.Customers", "Deleted", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Deleted", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "Updated", c => c.DateTime(nullable: false));
        }
    }
}
