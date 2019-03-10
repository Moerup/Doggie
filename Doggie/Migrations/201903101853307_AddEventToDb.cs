namespace Doggie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEventToDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Location = c.String(),
                        DogOwnerName = c.String(),
                        StartingTime = c.DateTime(nullable: false),
                        EstimatedTimeMinutes = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Events");
        }
    }
}
