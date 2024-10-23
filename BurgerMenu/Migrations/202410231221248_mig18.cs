namespace BurgerMenu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig18 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "Name", c => c.String());
            AlterColumn("dbo.Contacts", "Email", c => c.String());
            AlterColumn("dbo.Contacts", "Message", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "Message", c => c.Int(nullable: false));
            AlterColumn("dbo.Contacts", "Email", c => c.Int(nullable: false));
            AlterColumn("dbo.Contacts", "Name", c => c.Int(nullable: false));
        }
    }
}
