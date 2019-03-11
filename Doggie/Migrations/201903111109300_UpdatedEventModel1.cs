namespace Doggie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedEventModel1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Events", "Location", c => c.String(nullable: false));
            AlterColumn("dbo.Events", "DogOwnerName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Events", "DogOwnerName", c => c.String());
            AlterColumn("dbo.Events", "Location", c => c.String());
        }
    }
}
