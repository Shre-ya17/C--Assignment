using System.Collections.Generic;

namespace StudentInformationSystem.Entity
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseCode { get; set; }
        public string Title { get; set; }

        public List<Enrollment> Enrollments { get; set; }

        public Course()
        {
            Enrollments = new List<Enrollment>();
        }
    }
}
