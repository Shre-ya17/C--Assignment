using System.Collections.Generic;
using StudentInformationSystem.Entity;

namespace StudentInformationSystem.BusinessLayer.Repository
{
    public interface IEnrollmentRepository
    {
        void Add(Enrollment enrollment);
        IEnumerable<Enrollment> GetByStudentId(int studentId);
    }
}
