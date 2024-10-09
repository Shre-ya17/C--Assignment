using System;
using System.Collections.Generic;

namespace StudentInformationSystem.Entity
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }

        public List<Enrollment> Enrollments { get; set; }

        public Student()
        {
            Enrollments = new List<Enrollment>();
        }
    }
}
