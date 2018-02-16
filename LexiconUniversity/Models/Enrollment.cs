using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LexiconUniversity.Models
{
    public class Enrollment
    {
        public int      ID             { get; set; }
        //[Index("IX_CourseIdStudentId", 1, IsUnique=true)]
        public int      CourseId       { get; set; }
        //- Navigational property Många till en ett relation
        public virtual Course   Course { get; set; }          //- poppu:lera ordentligt

        //[Index("IX_CourseIdStudentId", 1, IsUnique=true)]
        public int      StudentId      { get; set; }
        public virtual Student Student { get; set; }

        public string   Grade          { get; set; }
        public DateTime EnrollmentDate { get; set; }


    }
}