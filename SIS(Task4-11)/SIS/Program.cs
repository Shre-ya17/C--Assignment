using SIS.Entity;
using SIS.Expectations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS
{
    class Program
    {
        static void Main(string[] args)
        {
            var sis = new SIS();

            var john = new Student(1, "John", "Doe");
            var course1 = new Course("CS101", "Introduction to Programming");
            var course2 = new Course("MATH101", "Mathematics 101");

            // Enroll John in courses
            try
            {
                sis.EnrollStudentInCourse(john, course1, DateTime.Now);
                sis.EnrollStudentInCourse(john, course2, DateTime.Now);
            }
            catch (DuplicateEnrollmentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Assign a teacher
            var sarah = new Teacher("Sarah Smith");
            sis.AssignCourseToTeacher(course1, sarah);

            // Output enrolled courses for John
            foreach (var enrollment in sis.GetEnrollmentsForStudent(john))
            {
                Console.WriteLine($"Student: {john.FirstName} {john.LastName}, Enrolled in: {enrollment.Course.CourseName}");
            }
        }
    }
}
