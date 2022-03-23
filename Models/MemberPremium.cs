using System;

namespace MemberMicroservice.Models
{
    public class MemberPremium
    {
        public int MemberID { get; set; }
        public int PolicyID { get; set; }
        public double PremiumDue { get; set; }
        public String PaymentDetails { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime LastPremiumPaidDate { get; set; }

    }
}
