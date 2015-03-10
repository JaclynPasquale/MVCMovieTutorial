namespace MVCMovieTutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renamestar : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MovieID = c.Int(nullable: false),
                        ApplicationUserID = c.String(),
                        Stars = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Movies", t => t.MovieID, cascadeDelete: true)
                .Index(t => t.MovieID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ratings", "MovieID", "dbo.Movies");
            DropIndex("dbo.Ratings", new[] { "MovieID" });
            DropTable("dbo.Ratings");
        }
    }
}
