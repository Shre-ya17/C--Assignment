using System.Collections.Generic;
using StudentInformationSystem.Entity;
using StudentInformationSystem.BusinessLayer.Repository;

namespace StudentInformationSystem.BusinessLayer.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public void AddPayment(Payment payment)
        {
            _paymentRepository.Add(payment);
        }

        public IEnumerable<Payment> GetPaymentsByStudentId(int studentId)
        {
            return _paymentRepository.GetByStudentId(studentId);
        }
    }
}
