using ContosoCore.Models.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoCore.Models.Entities
{
    public class Course:EtittyBase
    {
        public string Title { get; set; }
        public int Credits { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
