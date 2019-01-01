namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES('Friday the 13th', '14 January 2015', '" + DateTime.Now + "', 14, 7)");
            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES('Bird Box', '14 February 2018', '" + DateTime.Now + "', 20, 8)");
            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES('Black Panther', '16 February 2018', '" + DateTime.Now + "', 0, 9)");
            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES('Avengers - Infinity War', '4 April 2018', '" + DateTime.Now + "', 5, 10)");
            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES('A Quiet Place', '1 May 2018', '" + DateTime.Now + "', 14, 11)");
        }
        
        public override void Down()
        {
        }
    }
}
