using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Entity
{
    public class Payment
    {
        public Student Student { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        public Payment(Student student, decimal amount, DateTime paymentDate)
        {
            Student = student;
            Amount = amount;
            PaymentDate = paymentDate;
        }
    }
}
