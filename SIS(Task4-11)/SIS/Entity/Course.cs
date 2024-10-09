using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Entity
{
    public class Course
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public List<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

        public Course(string courseCode, string courseName)
        {
            CourseCode = courseCode;
            CourseName = courseName;
        }
    }
}
