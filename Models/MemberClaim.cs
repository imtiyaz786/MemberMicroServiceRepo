namespace MemberMicroservice.Models
{
    public class MemberClaim
    {
        public int ClaimID { get; set; }
        public string ClaimStatus { get; set; }
        public string Remarks { get; set; }
        public int PolicyID { get; set; }
        public string HospitalDetails { get; set; }
        public string BenefitsAvailed { get; set; }
        public decimal AmountClaimed { get; set; }
        public string Settled { get; set; }
    }
}
