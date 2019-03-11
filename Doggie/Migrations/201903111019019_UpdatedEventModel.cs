namespace Doggie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedEventModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Events", "Comment", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "Comment");
            DropColumn("dbo.Events", "Date");
        }
    }
}
