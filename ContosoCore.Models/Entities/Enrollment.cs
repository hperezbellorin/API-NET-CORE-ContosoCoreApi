using ContosoCore.Models.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoCore.Models.Entities
{
    public enum Grade
    {
        A,B,C,D,E
    }
    public class Enrollment:EtittyBase
    {
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
