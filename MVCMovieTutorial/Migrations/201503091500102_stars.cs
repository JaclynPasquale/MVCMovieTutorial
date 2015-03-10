namespace MVCMovieTutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stars : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Stars", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Stars");
        }
    }
}
