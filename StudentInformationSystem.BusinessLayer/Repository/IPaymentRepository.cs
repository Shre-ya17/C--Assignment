using System.Collections.Generic;
using StudentInformationSystem.Entity;

namespace StudentInformationSystem.BusinessLayer.Repository
{
    public interface IPaymentRepository
    {
        void Add(Payment payment);
        IEnumerable<Payment> GetByStudentId(int studentId);
    }
}
