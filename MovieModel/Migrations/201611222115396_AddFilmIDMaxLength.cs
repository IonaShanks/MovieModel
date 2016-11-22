namespace MovieModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFilmIDMaxLength : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cinemas", "FilmID", "dbo.MovieListings");
            DropIndex("dbo.Cinemas", new[] { "FilmID" });
            DropPrimaryKey("dbo.MovieListings");
            AlterColumn("dbo.Cinemas", "FilmID", c => c.String(maxLength: 10));
            AlterColumn("dbo.MovieListings", "FilmID", c => c.String(nullable: false, maxLength: 10));
            AddPrimaryKey("dbo.MovieListings", "FilmID");
            CreateIndex("dbo.Cinemas", "FilmID");
            AddForeignKey("dbo.Cinemas", "FilmID", "dbo.MovieListings", "FilmID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cinemas", "FilmID", "dbo.MovieListings");
            DropIndex("dbo.Cinemas", new[] { "FilmID" });
            DropPrimaryKey("dbo.MovieListings");
            AlterColumn("dbo.MovieListings", "FilmID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Cinemas", "FilmID", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.MovieListings", "FilmID");
            CreateIndex("dbo.Cinemas", "FilmID");
            AddForeignKey("dbo.Cinemas", "FilmID", "dbo.MovieListings", "FilmID");
        }
    }
}
