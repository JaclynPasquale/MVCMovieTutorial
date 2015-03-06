namespace MVCMovieTutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HasRazzie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "HasRazzie", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "HasRazzie");
        }
    }
}
