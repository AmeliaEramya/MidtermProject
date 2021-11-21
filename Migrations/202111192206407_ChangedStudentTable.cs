namespace MidtermProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedStudentTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "DateOfBirth", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Students", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Grade", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Grade", c => c.String());
            AlterColumn("dbo.Students", "FirstName", c => c.String());
            DropColumn("dbo.Students", "DateOfBirth");
        }
    }
}
