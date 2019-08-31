using ContosoCore.Models.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoCore.Models.Entities
{
    public class Student: EtittyBase
    {
        public string LastName { get; set; }
        public string FisrtMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
