using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace LexiconUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None )]  //- anger att class+Id skall ge primärnyckel, här: CourseId
        public int    CourseId { get; set; }
        public string Title    { get; set; }
        public int    Credits  { get; set; }

        //- Navigational property
        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}