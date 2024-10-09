using System.Collections.Generic;

namespace StudentInformationSystem.Entity
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<Course> AssignedCourses { get; set; }

        public Teacher()
        {
            AssignedCourses = new List<Course>();
        }
    }
}
