namespace ConcertEvents.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Events", "ApplicationUserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "ApplicationUserId", c => c.String());
        }
    }
}
