using System.Collections.Generic;
using System.Linq;
using StudentInformationSystem.Entity;

namespace StudentInformationSystem.BusinessLayer.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly List<Payment> _payments = new List<Payment>();

        public void Add(Payment payment)
        {
            _payments.Add(payment);
        }

        public IEnumerable<Payment> GetByStudentId(int studentId)
        {
            return _payments.Where(p => p.Student.Id == studentId).ToList();
        }
    }
}
