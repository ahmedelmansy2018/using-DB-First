namespace HopeUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCourseSeat : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Seat", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "Seat");
        }
    }
}
