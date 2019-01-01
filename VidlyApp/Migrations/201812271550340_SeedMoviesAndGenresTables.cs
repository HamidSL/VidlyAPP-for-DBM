namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMoviesAndGenresTables : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Name) VALUES('Drama')");
            Sql("INSERT INTO Genres(Name) VALUES('Romance')");
            Sql("INSERT INTO Genres(Name) VALUES('Thriller')");
            Sql("INSERT INTO Genres(Name) VALUES('Action')");
            Sql("INSERT INTO Genres(Name) VALUES('Comedy')");
            Sql("INSERT INTO Genres(Name) VALUES('Sci-fi')");
            


            
        }
        
        public override void Down()
        {
        }
    }
}
