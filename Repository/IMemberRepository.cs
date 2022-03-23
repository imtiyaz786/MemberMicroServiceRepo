using MemberMicroservice.Models;

namespace MemberMicroservice.Repository
{
    public interface IMemberRepository
    {
        public MemberPremium ViewBill(int PolicyID,  int MemberID);
        Member GetMember(LoginModel model);
        public string GetClaimStatus(int ClaimID, int PolicyID, int memberID);
        public string SubmitClaim(int policyID, int memberID, int benefitID, int hospitalID, double claimAmt, string benefit);
    }
}
