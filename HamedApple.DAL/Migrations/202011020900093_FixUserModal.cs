namespace HamedApple.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixUserModal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "FullName", c => c.String(nullable: false));
            AlterColumn("dbo.AspNetUsers", "NationCode", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.AspNetUsers", "MobileNumber", c => c.String(nullable: false, maxLength: 11));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "MobileNumber", c => c.String());
            AlterColumn("dbo.AspNetUsers", "NationCode", c => c.String());
            AlterColumn("dbo.AspNetUsers", "FullName", c => c.String());
        }
    }
}
