using System.Collections.Generic;
using StudentInformationSystem.Entity;
using StudentInformationSystem.BusinessLayer.Repository;

namespace StudentInformationSystem.BusinessLayer.Services
{
    public class EnrollmentService : IEnrollmentService
    {
        private readonly IEnrollmentRepository _enrollmentRepository;

        public EnrollmentService(IEnrollmentRepository enrollmentRepository)
        {
            _enrollmentRepository = enrollmentRepository;
        }

        public void EnrollStudentInCourse(Enrollment enrollment)
        {
            _enrollmentRepository.Add(enrollment);
        }

        public IEnumerable<Enrollment> GetEnrollmentsByStudentId(int studentId)
        {
            return _enrollmentRepository.GetByStudentId(studentId);
        }
    }
}
