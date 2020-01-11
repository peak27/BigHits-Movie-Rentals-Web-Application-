namespace BigHits.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreID = c.Int(nullable: false, identity: true),
                        GenreType = c.String(nullable: false, maxLength: 100),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.GenreID);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieID = c.Int(nullable: false, identity: true),
                        MoviesName = c.String(nullable: false, maxLength: 100),
                        ReYear = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 500),
                        UnitPrice = c.Double(),
                        Rating = c.String(),
                        FileName = c.String(),
                        ImgPath = c.String(),
                        AltText = c.String(),
                        GenreID = c.Int(),
                    })
                .PrimaryKey(t => t.MovieID)
                .ForeignKey("dbo.Genres", t => t.GenreID)
                .Index(t => t.GenreID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreID", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreID" });
            DropTable("dbo.Movies");
            DropTable("dbo.Genres");
        }
    }
}
