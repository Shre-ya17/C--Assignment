using SIS.Entity;
using SIS.Expectations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS
{
    public class SIS
    {
        private List<Student> students = new List<Student>();
        private List<Course> courses = new List<Course>();

        public void EnrollStudentInCourse(Student student, Course course, DateTime enrollmentDate)
        {
            if (student.Enrollments.Exists(e => e.Course == course))
                throw new DuplicateEnrollmentException("Student is already enrolled in this course.");

            var enrollment = new Enrollment(student, course, enrollmentDate);
            student.Enrollments.Add(enrollment);
            course.Enrollments.Add(enrollment);
        }

        public void AssignCourseToTeacher(Course course, Teacher teacher)
        {
            teacher.AssignedCourses.Add(course);
        }

        public void AddPayment(Student student, decimal amount, DateTime paymentDate)
        {
            // Here you would normally add the payment to a database
        }

        public List<Enrollment> GetEnrollmentsForStudent(Student student)
        {
            return student.Enrollments;
        }

        public List<Course> GetCoursesForTeacher(Teacher teacher)
        {
            return teacher.AssignedCourses;
        }
    }
}
