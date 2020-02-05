namespace MovieLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RedoPopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1,'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2,'Adventure')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3,'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4,'Drama')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5,'Documentary')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (7,'Musical')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (8,'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (9,'Science Fiction')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (10,'Western')");
        }
        
        public override void Down()
        {
        }
    }
}
