namespace BurgerMenu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "Email", c => c.String());
            AddColumn("dbo.Admins", "Name", c => c.String());
            AddColumn("dbo.Admins", "Surname", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Admins", "Surname");
            DropColumn("dbo.Admins", "Name");
            DropColumn("dbo.Admins", "Email");
        }
    }
}
