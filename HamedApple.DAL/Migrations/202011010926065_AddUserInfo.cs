namespace HamedApple.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FullName", c => c.String());
            AddColumn("dbo.AspNetUsers", "NationCode", c => c.String());
            AddColumn("dbo.AspNetUsers", "MobileNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "MobileNumber");
            DropColumn("dbo.AspNetUsers", "NationCode");
            DropColumn("dbo.AspNetUsers", "FullName");
        }
    }
}
