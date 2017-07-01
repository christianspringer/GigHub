namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Rock')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Jazz')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Pop-Punk')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Alt-Rock')");
        }

        public override void Down()
        {
        }
    }
}
