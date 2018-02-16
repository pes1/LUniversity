using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LexiconUniversity.Models
{
    public class Student
    {
        public int                     Id          { get; set; }
        public string                  FirstName   { get; set; }
        [Required] //- databasregel   även i MVC. Övergår från null:able till ett värde
        public string                  LastName    { get; set; }
        //- Navigational property
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}