using System;

namespace StudentInformationSystem.Entity
{
    public class Payment
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public Student Student { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
