namespace ConcertEvents.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Events", "Time");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "Time", c => c.DateTime(nullable: false));
        }
    }
}
