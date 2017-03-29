namespace TrashCollectorPro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ZipCode1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "CurrentlyActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "SuspendService", c => c.String());
            AddColumn("dbo.AspNetUsers", "ResumeService", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "ResumeService");
            DropColumn("dbo.AspNetUsers", "SuspendService");
            DropColumn("dbo.AspNetUsers", "CurrentlyActive");
        }
    }
}
