namespace MovieModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cinemas",
                c => new
                    {
                        CinemaID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Website = c.String(),
                        PhoneNumber = c.String(),
                        TicketPrice = c.String(),
                        FilmID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.CinemaID)
                .ForeignKey("dbo.MovieListings", t => t.FilmID)
                .Index(t => t.FilmID);
            
            CreateTable(
                "dbo.MovieListings",
                c => new
                    {
                        FilmID = c.String(nullable: false, maxLength: 128),
                        Title = c.String(nullable: false),
                        Certification = c.Int(nullable: false),
                        Genre = c.String(nullable: false),
                        Description = c.String(),
                        RunTime = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.FilmID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cinemas", "FilmID", "dbo.MovieListings");
            DropIndex("dbo.Cinemas", new[] { "FilmID" });
            DropTable("dbo.MovieListings");
            DropTable("dbo.Cinemas");
        }
    }
}
