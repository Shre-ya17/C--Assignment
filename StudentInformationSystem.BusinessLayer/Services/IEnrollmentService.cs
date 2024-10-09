using System.Collections.Generic;
using StudentInformationSystem.Entity;

namespace StudentInformationSystem.BusinessLayer.Services
{
    public interface IEnrollmentService
    {
        void EnrollStudentInCourse(Enrollment enrollment);
        IEnumerable<Enrollment> GetEnrollmentsByStudentId(int studentId);
    }
}
