namespace TrashCollectorPro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ZipCode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "ZipCode", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "ZipCode");
        }
    }
}
