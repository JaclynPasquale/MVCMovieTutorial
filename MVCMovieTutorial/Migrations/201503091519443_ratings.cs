namespace MVCMovieTutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ratings : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "Stars");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Stars", c => c.Int(nullable: false));
        }
    }
}
