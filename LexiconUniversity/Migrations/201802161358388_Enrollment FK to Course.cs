namespace LexiconUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EnrollmentFKtoCourse : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Enrollments", "CourseId");
            CreateIndex("dbo.Enrollments", "StudentId");
            AddForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses", "CourseId", cascadeDelete: true);
            AddForeignKey("dbo.Enrollments", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollments", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses");
            DropIndex("dbo.Enrollments", new[] { "StudentId" });
            DropIndex("dbo.Enrollments", new[] { "CourseId" });
        }
    }
}
