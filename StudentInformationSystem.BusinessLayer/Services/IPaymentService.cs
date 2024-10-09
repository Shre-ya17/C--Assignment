using System.Collections.Generic;
using StudentInformationSystem.Entity;

namespace StudentInformationSystem.BusinessLayer.Services
{
    public interface IPaymentService
    {
        void AddPayment(Payment payment);
        IEnumerable<Payment> GetPaymentsByStudentId(int studentId);
    }
}
