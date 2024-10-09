using SIS.Entity;
using SIS.Expectations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Services
{
    public void AddEnrollment(Student student, Course course, DateTime enrollmentDate)
    {
        // Check if student is already enrolled in the course
        if (course.Enrollments.Exists(e => e.Student.StudentId == student.StudentId))
        {
            throw new DuplicateEnrollmentException("Student is already enrolled in this course.");
        }

        // Create new enrollment
        Enrollment enrollment = new Enrollment
        {
            Student = student,
            Course = course,
            EnrollmentDate = enrollmentDate
        };

        // Add enrollment to student and course
        student.Enrollments.Add(enrollment);
        course.Enrollments.Add(enrollment);
    }

    // Method to assign a course to a teacher
    public void AssignCourseToTeacher(Course course, Teacher teacher)
    {
        // Check if the course already has a teacher
        if (teacher.AssignedCourses.Contains(course))
        {
            throw new CourseNotFoundException("Course already assigned to this teacher.");
        }

        teacher.AssignedCourses.Add(course);
    }

    // Method to add a payment
    public void AddPayment(Student student, decimal amount, DateTime paymentDate)
    {
        if (amount <= 0)
        {
            throw new PaymentValidationException("Invalid payment amount.");
        }

        // Add payment to student
        Payment payment = new Payment
        {
            Student = student,
            Amount = amount,
            PaymentDate = paymentDate
        };

        student.Payments.Add(payment);
    }

    // Method to retrieve enrollments for a student
    public List<Enrollment> GetEnrollmentsForStudent(Student student)
    {
        return student.Enrollments;
    }

    // Method to retrieve courses for a teacher
    public List<Course> GetCoursesForTeacher(Teacher teacher)
    {
        return teacher.AssignedCourses;
    }
}
}
