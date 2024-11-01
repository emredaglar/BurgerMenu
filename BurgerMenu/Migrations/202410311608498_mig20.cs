namespace BurgerMenu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig20 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "SendDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "SendDate");
        }
    }
}
