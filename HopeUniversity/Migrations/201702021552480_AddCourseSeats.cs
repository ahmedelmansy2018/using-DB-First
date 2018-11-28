namespace HopeUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCourseSeats : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Seats", t => t.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "Seats");
        }
    }
}
