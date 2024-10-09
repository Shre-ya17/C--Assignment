using System.Collections.Generic;
using System.Linq;
using StudentInformationSystem.Entity;

namespace StudentInformationSystem.BusinessLayer.Repository
{
    public class EnrollmentRepository : IEnrollmentRepository
    {
        private readonly List<Enrollment> _enrollments = new List<Enrollment>();

        public void Add(Enrollment enrollment)
        {
            _enrollments.Add(enrollment);
        }

        public IEnumerable<Enrollment> GetByStudentId(int studentId)
        {
            return _enrollments.Where(e => e.Student.Id == studentId).ToList();
        }
    }
}
