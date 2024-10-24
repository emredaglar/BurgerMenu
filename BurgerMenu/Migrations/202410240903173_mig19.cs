namespace BurgerMenu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig19 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "Subtitle", c => c.String());
            AddColumn("dbo.Abouts", "Title", c => c.String());
            AddColumn("dbo.Abouts", "Description", c => c.String());
            AddColumn("dbo.Abouts", "ImageUrl", c => c.String());
            AddColumn("dbo.Abouts", "Address", c => c.String());
            AddColumn("dbo.Abouts", "Phone", c => c.String());
            AddColumn("dbo.Abouts", "Email", c => c.String());
            AddColumn("dbo.Abouts", "MapLocation", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Abouts", "MapLocation");
            DropColumn("dbo.Abouts", "Email");
            DropColumn("dbo.Abouts", "Phone");
            DropColumn("dbo.Abouts", "Address");
            DropColumn("dbo.Abouts", "ImageUrl");
            DropColumn("dbo.Abouts", "Description");
            DropColumn("dbo.Abouts", "Title");
            DropColumn("dbo.Abouts", "Subtitle");
        }
    }
}
