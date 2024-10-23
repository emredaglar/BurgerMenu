namespace BurgerMenu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig11 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "ProductName", c => c.String(maxLength: 100));
            DropColumn("dbo.Products", "CategoryName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "CategoryName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Products", "ProductName", c => c.String());
        }
    }
}
