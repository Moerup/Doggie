namespace Doggie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StartingTimeChangedToTimeSpan : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Events", "StartingTime", c => c.Time(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Events", "StartingTime", c => c.DateTime(nullable: false));
        }
    }
}
