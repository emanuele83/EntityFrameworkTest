namespace CodeFirstExistingDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletePublishedColumnFromCourseTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Courses", "Published");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Published", c => c.DateTime());
        }
    }
}
