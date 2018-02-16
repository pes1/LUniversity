namespace LexiconUniversity.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using LexiconUniversity.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<LexiconUniversity.Models.LexiconUniversityContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "LexiconUniversity.Models.LexiconUniversityContext";
        }

        protected override void Seed(LexiconUniversity.Models.LexiconUniversityContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Courses.AddOrUpdate(
                c => c.CourseId,
                new Course { CourseId = 1050, Title = ".NET",   Credits = 30 },
                new Course { CourseId = 1051, Title = "Java",   Credits = 28 },
                new Course { CourseId = 1052, Title = "Haskel", Credits = 31 },
                new Course { CourseId = 1053, Title = "Erlang", Credits = 55 }
                );


            var students = new Student[]
            {
                new Student {FirstName="Adam",    LastName = "Andersson"},
                new Student {FirstName="Berit",   LastName = "Bosson"   },
                new Student {FirstName="Cecilia", LastName = "Carlsson" },
                new Student {FirstName="David",   LastName = "Duke"     },
                new Student {FirstName="Erik",    LastName = "Eriksson"     },
                new Student {FirstName="Filip",   LastName = "Filipsson"     }
            };


            context.Students.AddOrUpdate (
                //s =>s.FirstName, 
                s=> new {s.FirstName, s.LastName},
                students);


            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment  {StudentId = students[0].Id, CourseId = 1050, EnrollmentDate=DateTime.Parse("2017-01-12"), Grade="MVG" },
                new Enrollment  {StudentId = students[1].Id, CourseId = 1053, EnrollmentDate=DateTime.Parse("2017-01-12"), Grade="MVG" },
                new Enrollment  {StudentId = students[2].Id, CourseId = 1051, EnrollmentDate=DateTime.Today },
                new Enrollment  {StudentId = students[3].Id, CourseId = 1051, EnrollmentDate=DateTime.Today },
                new Enrollment  {StudentId = students[4].Id, CourseId = 1053, EnrollmentDate=DateTime.Parse("2017-01-12"), Grade="MVG" },
                new Enrollment  {StudentId = students[5].Id, CourseId = 1053, EnrollmentDate=DateTime.Parse("2017-01-12"), Grade="MVG" },
            };

            context.Enrollments.AddOrUpdate(
                e => new { e.StudentId, e.CourseId },
            enrollments);

            context.SaveChanges();
        }
    }
}
