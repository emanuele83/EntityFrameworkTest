namespace CodeFirstExistingDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPublishedColumnToCourseTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Published", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "Published");
        }
    }
}
