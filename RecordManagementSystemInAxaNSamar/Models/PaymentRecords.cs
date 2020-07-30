using System;

namespace RecordManagementSystemInAxaNSamar.Model
{
    public class PaymentRecords
    {
        public int PaymentId { get; set; }
        public int PaymentPaid { get; set; }
        public DateTime? PaidDate { get; set; }
        public string PolicyNumberPayment { get; set; }

    }
}