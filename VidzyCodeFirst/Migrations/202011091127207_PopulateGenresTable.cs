namespace VidzyCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres VALUES (1, 'Horror')");
            Sql("INSERT INTO Genres VALUES (2, 'Thriller')");
            Sql("INSERT INTO Genres VALUES (3, 'Drama')");
            Sql("INSERT INTO Genres VALUES (4, 'Comedy')");
            Sql("INSERT INTO Genres VALUES (5, 'Sit-Com')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres");
        }
    }
}
